using System.Buffers;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using Silk.NET.Core.Contexts;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace Silk.NET.X11;

/// <summary>
///     Abstracts away common view functions to ease implementation of the windowing API.
/// </summary>
[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class ViewImplementationBase : IView {
	private const int InitialInvocationRental = 2;

	// Cache the options for when the window is closed
	protected ViewOptions _optionsCache;

	// Game loop fields
	private readonly Stopwatch _renderStopwatch   = new Stopwatch();
	private readonly Stopwatch _updateStopwatch   = new Stopwatch();
	private readonly Stopwatch _lifetimeStopwatch = new Stopwatch();
	private          double    _renderPeriod;
	private          double    _updatePeriod;

	// Invocations
	private readonly ArrayPool<object>    _returnArrayPool = ArrayPool<object>.Create();
	private          PendingInvocation[]? _pendingInvocations;
	private          int                  _rented;

	// Ensure we keep SwapInterval up-to-date
	private bool _swapIntervalChanged = true;

    /// <summary>
    ///     Creates a base view with the given options.
    /// </summary>
    /// <param name="opts">The options, used to configure the view.</param>
    protected ViewImplementationBase(ViewOptions opts) {
		this._optionsCache    = opts;
		this.FramesPerSecond  = opts.FramesPerSecond;
		this.UpdatesPerSecond = opts.UpdatesPerSecond;
	}

	// Property bases - these have extra functionality baked into their getters and setters
	protected abstract Vector2D<int> CoreSize      { get; set; }
	protected abstract nint          CoreHandle    { get; }
	protected abstract bool          CoreIsClosing { get; }
	protected abstract IGLContext?   CoreGLContext { get; }
	protected abstract IVkSurface?   CoreVkSurface { get; }

	// Function bases - again extra functionality on top
	protected abstract void CoreInitialize(ViewOptions opts);
	protected abstract void CoreReset();

	// Other APIs implemented abstractly
	public abstract    VideoMode     VideoMode       { get; }
	public abstract    bool          IsEventDriven   { get; set; }
	public abstract    Vector2D<int> FramebufferSize { get; }
	public abstract    void          DoEvents();
	public abstract    void          ContinueEvents();
	public abstract    Vector2D<int> PointToClient(Vector2D<int> point);
	public abstract    Vector2D<int> PointToScreen(Vector2D<int> point);
	public abstract    void          Close();
	protected abstract void          RegisterCallbacks();
	protected abstract void          UnregisterCallbacks();
	protected abstract INativeWindow GetNativeWindow();

	// Events
	public abstract event Action<Vector2D<int>>? Resize;
	public abstract event Action<Vector2D<int>>? FramebufferResize;
	public abstract event Action?                Closing;
	public abstract event Action<bool>?          FocusChanged;
	public event          Action?                Load;
	public event          Action<double>?        Update;
	public event          Action<double>?        Render;
	internal event        Action?                ProcessEvents;

	// Lifetime controls
	public void Initialize() {
		if (this.IsInitialized)
			return;

		this.CoreInitialize(this._optionsCache);
		this.RegisterCallbacks();
		this.EnsureArrayIsReady(-1);
		this._renderStopwatch.Start();
		this._updateStopwatch.Start();
		this._lifetimeStopwatch.Start();
		this.IsInitialized = true;
		this.IsEventDriven = this._optionsCache.IsEventDriven;
		this.GLContext?.MakeCurrent();
		this._swapIntervalChanged = true;
		this.Native               = this.GetNativeWindow();
		this.Load?.Invoke();
	}

	public void Reset() {
		if (!this.IsInitialized)
			return;

		this.IsInitialized = false;
		this._renderStopwatch.Reset();
		this._updateStopwatch.Reset();
		this._lifetimeStopwatch.Reset();
		this.CoreReset();
		this.UnregisterCallbacks();
		this.Native = null;
	}

	// Game loop controls
	public double FramesPerSecond {
		get => this._renderPeriod <= double.Epsilon ? 0 : 1 / this._renderPeriod;
		set => this._renderPeriod = value <= double.Epsilon ? 0 : 1 / value;
	}

	public double UpdatesPerSecond {
		get => this._updatePeriod <= double.Epsilon ? 0 : 1 / this._updatePeriod;
		set => this._updatePeriod = value <= double.Epsilon ? 0 : 1 / value;
	}

	public bool IsContextControlDisabled {
		get => this._optionsCache.IsContextControlDisabled;
		set => this._optionsCache.IsContextControlDisabled = value;
	}

	public bool ShouldSwapAutomatically {
		get => this._optionsCache.ShouldSwapAutomatically;
		set => this._optionsCache.ShouldSwapAutomatically = value;
	}

	// Cache controls for derived classes
	protected VideoMode CachedVideoMode {
		get => this._optionsCache.VideoMode;
		set => this._optionsCache.VideoMode = value;
	}

	// Game loop implementation
	public virtual void Run(Action onFrame) {
		while (!this.IsClosing)
			onFrame();
	}

	public void DoRender() {
		this.DoInvokes();
		var delta = this._renderStopwatch.Elapsed.TotalSeconds;
		if (delta >= this._renderPeriod || this.VSync) {
			if (!this.IsContextControlDisabled && !(this.GLContext is null) && !this.GLContext.IsCurrent)
				this.GLContext.MakeCurrent();

			if (!this.IsContextControlDisabled && this._swapIntervalChanged) {
				this.GLContext?.SwapInterval(this.VSync ? 1 : 0);
				this._swapIntervalChanged = false;
			}

			delta = this._renderStopwatch.Elapsed.TotalSeconds;
			this._renderStopwatch.Restart();
			this.Render?.Invoke(delta);

			if (!this.IsContextControlDisabled && this.ShouldSwapAutomatically)
				this.GLContext?.SwapBuffers();
		}
	}

	public void DoUpdate() {
		var delta = this._updateStopwatch.Elapsed.TotalSeconds;
		if (delta >= this._updatePeriod) {
			this._updateStopwatch.Restart();
			this.Update?.Invoke(delta);
		}
	}

	// Misc properties
	public bool           IsInitialized              { get; protected set; }
	public INativeWindow? Native                     { get; private set; }
	public Vector2D<int>  Size                       => this.IsInitialized ? this.CoreSize : default;
	public nint           Handle                     => this.IsInitialized ? this.CoreHandle : 0;
	public bool           IsClosing                  => !this.IsInitialized || this.CoreIsClosing; // IsClosing = true if window is reset halts game loop
	public GraphicsAPI    API                        => this._optionsCache.API;
	public double         Time                       => this._lifetimeStopwatch.Elapsed.TotalSeconds;
	public int?           PreferredDepthBufferBits   => this._optionsCache.PreferredDepthBufferBits;
	public int?           PreferredStencilBufferBits => this._optionsCache.PreferredStencilBufferBits;
	public Vector4D<int>? PreferredBitDepth          => this._optionsCache.PreferredBitDepth;
	public int?           Samples                    => this._optionsCache.Samples;

	public bool VSync {
		get => this._optionsCache.VSync;
		set {
			this._swapIntervalChanged = true;
			this._optionsCache.VSync  = value;
		}
	}

	public IGLContext? GLContext {
		get {
			if (!this.IsInitialized && (this.API.API == ContextAPI.OpenGL || this.API.API == ContextAPI.OpenGLES)) {
				static void Throw() {
					throw new InvalidOperationException
					(
						"OpenGL functions can only be used after initialization (just before the Load callback is " +
						"executed)"
					);
				}

				Throw();
			}
			else if (this.API.API != ContextAPI.OpenGL && this.API.API != ContextAPI.OpenGLES) {
				return null;
			}

			return this.CoreGLContext;
		}
	}

	public IVkSurface? VkSurface {
		get {
			if (!this.IsInitialized && this.API.API == ContextAPI.Vulkan) {
				static void Throw() {
					throw new InvalidOperationException
					(
						"Vulkan functions can only be used after initialization (just before the Load callback is " +
						"executed)"
					);
				}

				Throw();
			}
			else if (this.API.API != ContextAPI.Vulkan) {
				return null;
			}

			return this.CoreVkSurface;
		}
	}

	// Misc implementations
	void IView.DoEvents() {
		this.DoEvents();
		this.ProcessEvents?.Invoke();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining | (MethodImplOptions)512)]
	public Vector2D<int> PointToFramebuffer(Vector2D<int> point) {
		// TODO this monstrosity will be gone once Silk.NET.Maths has intrinsics
		if (Vector.IsHardwareAccelerated && Vector<int>.Count >= 2) {
#if NETSTANDARD2_1
                // ReSharper disable SuggestVarOrType_Elsewhere
                Span<int> framebufferSizeElements = stackalloc int[Vector<int>.Count];
                Unsafe.As<int, Vector2D<int>>(ref framebufferSizeElements[0]) = FramebufferSize;
                var framebufferSize = new Vector<int>(framebufferSizeElements);
                Span<int> sizeElements = stackalloc int[Vector<int>.Count];
                // HACK: Avoid divide by zero errors
                sizeElements[2..].Fill(1);
                Unsafe.As<int, Vector2D<int>>(ref sizeElements[0]) = Size;
                var size = new Vector<int>(sizeElements);
                Span<int> pointElements = stackalloc int[Vector<int>.Count];
                Unsafe.As<int, Vector2D<int>>(ref pointElements[0]) = point;
                var thePoint = new Vector<int>(pointElements);
                // ReSharper restore SuggestVarOrType_Elsewhere
#else
			var   c = Vector<int>.Count;
			int[] a = new int[c * 3];
			Unsafe.As<int, Vector2D<int>>(ref a[0])     = this.FramebufferSize;
			Unsafe.As<int, Vector2D<int>>(ref a[c])     = this.Size;
			Unsafe.As<int, Vector2D<int>>(ref a[c * 2]) = point;

			// HACK: Avoid divide by zero errors
			for (int i = c + 2; i < c * 2; i++)
				a[i] = 1;

			var framebufferSize = new Vector<int>(a, 0);
			var size            = new Vector<int>(a, c);
			var thePoint        = new Vector<int>(a, c * 2);
#endif
			thePoint = Vector.Multiply(thePoint, Vector.Divide(framebufferSize, size));
			return new Vector2D<int>(thePoint[0], thePoint[1]);
		}

		var fSize = this.FramebufferSize;
		var aSize = this.Size;
		return new Vector2D<int> {
			X = point.X * (fSize.X / aSize.X),
			Y = point.Y * (fSize.Y / aSize.Y)
		};
	}

	public virtual void Dispose() {
		this.Reset();
		GC.SuppressFinalize(this);
	}

	// Invoke system
	public object Invoke(Delegate d, params object[] args) {
		int rentalIndex = Interlocked.Increment(ref this._rented) - 1;
		this.EnsureArrayIsReady(rentalIndex);
		ref PendingInvocation x = ref this._pendingInvocations![rentalIndex];
		x.Delegate = d;
		x.Data     = args;
		x.ResetEvent.Reset();
		x.IsComplete = false;
		x.ResetEvent.Wait();
		object ret = x.Data[0];
		this._returnArrayPool.Return(x.Data);
		x.Delegate = null;
		x.Data     = null;
		return ret;
	}

	public void DoInvokes() {
		if (this._pendingInvocations is null)
			return;

		int completed = 0;
		for (int i = 0; i < this._rented + completed && i < this._pendingInvocations.Length; i++) {
			ref PendingInvocation invocation = ref this._pendingInvocations[i];
			if (invocation.IsComplete || invocation.Delegate is null) {
				completed++;
			}
			else {
				var ret = this._returnArrayPool.Rent(1);
				ret[0]                = invocation.Delegate.DynamicInvoke(invocation.Data);
				invocation.Data       = ret;
				invocation.IsComplete = true;
				invocation.ResetEvent.Set();
				Interlocked.Decrement(ref this._rented);
			}
		}
	}

	private void EnsureArrayIsReady(int rentalIndex) {
		this._pendingInvocations ??= new PendingInvocation[InitialInvocationRental];

		if (rentalIndex == -1)
			return;

		int finalSize = this._pendingInvocations.Length;
		while (rentalIndex + 1 > finalSize)
			finalSize *= 2;

		if (finalSize == this._pendingInvocations.Length)
			return;

		PendingInvocation[]  na = new PendingInvocation[finalSize];
		PendingInvocation[]? og = Interlocked.Exchange(ref this._pendingInvocations, na);
		og?.CopyTo(na, 0);
		for (int i = 0; i < na.Length; i++)
			na[i].ResetEvent ??= new ManualResetEventSlim();
	}

	private struct PendingInvocation {
		public bool                 IsComplete { get; set; }
		public Delegate?            Delegate   { get; set; }
		public object[]?            Data       { get; set; }
		public ManualResetEventSlim ResetEvent { get; set; }
	}
}
