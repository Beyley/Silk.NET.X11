using System.Reflection;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.Windowing;
using TerraFX.Interop.Xlib;
using Window = TerraFX.Interop.Xlib.Window;
using Silk.NET.GLX;

namespace Silk.NET.X11; 

public unsafe class X11Window : WindowImplementationBase {
	public Window       Window;
	public Display*     Display;
	public XVisualInfo* VisualInfo = null;

	private Queue<XEvent> _eventQueue = new();
	private INativeWindow _native;
	private Atom          _wmDeleteWindow;
	private string        _windowClass;

	public X11Window(WindowOptions optionsCache) : base(optionsCache) {}
	protected override Vector2D<int> CoreSize {
		get;
		set;
	}
	protected override nint CoreHandle {
		get;
	}
	
	protected override bool         CoreIsClosing => this._isClosing;
	private            bool         _isClosing  = false;

	private            X11GLContext? _x11GlContext;
	protected override IGLContext?   CoreGLContext => this._x11GlContext ??= new X11GLContext(this);

	protected override IVkSurface? CoreVkSurface {
		get;
	}
	protected override void CoreReset() {
		if (this.Window == Window.NULL)
			return;

		this._x11GlContext?.Dispose();

		int result = Xlib.XUnmapWindow(this.Display, this.Window);
		
		// if (result != 0)
			// throw new PlatformException();
		
		result = Xlib.XDestroyWindow(this.Display, this.Window);

		// if (result != 0)
			// throw new PlatformException();
	}
	public override VideoMode VideoMode {
		get;
	}
	public override bool IsEventDriven {
		get;
		set;
	}
	public override Vector2D<int> FramebufferSize {
		get;
	}
	public override void DoEvents() {
		this._eventQueue.Clear();

		XEvent e;
		if (this.IsEventDriven) {
			if (Xlib.XPending(this.Display) != 0) {
				if (Xlib.XNextEvent(this.Display, &e) != 0)
					throw new PlatformException();

				this._eventQueue.Enqueue(e);
			}
		}
		else {
			while (Xlib.XPending(this.Display) != 0) {
				if (Xlib.XNextEvent(this.Display, &e) != 0)
					throw new PlatformException();
			
				Console.WriteLine($"Enqueuing events!");
				this._eventQueue.Enqueue(e);
			}
		}

		this.ProcessEvents();
	}
	public virtual void ProcessEvents() {
		while (this._eventQueue.TryDequeue(out XEvent e)) {
			if (e.type == Xlib.Expose) {
				// XExposeEvent exposeEvent = xEvent.xexpose;
			}
			if (e.type              == Xlib.ClientMessage &&
				e.xclient.data.l[0] == this._wmDeleteWindow) {
				this.Close();
			}
			if (e.type == Xlib.ConfigureNotify) {
				if (e.xconfigure.width != this.Size.X || e.xconfigure.height != this.Size.Y) {
					Console.WriteLine($"Window size changed!");
					this.CoreSize = new Vector2D<int>(e.xconfigure.width, e.xconfigure.height);
					this.Resize?.Invoke(this.CoreSize);
				}
			}
			Console.WriteLine(e.type);
		}
	}
	public override void ContinueEvents() {
		// throw new NotImplementedException();
	}
	public override void Close() {
		this.CoreReset();		
		this.Closing?.Invoke();
		this._isClosing = true;
	}
	protected override void RegisterCallbacks() {
		// throw new NotImplementedException();
	}
	protected override void UnregisterCallbacks() {
		// throw new NotImplementedException();
	}

	protected override INativeWindow GetNativeWindow() => this._native;
	
	public override event Action<Vector2D<int>>? Resize;
	public override event Action<Vector2D<int>>? FramebufferResize;
	public override event Action?                Closing;
	public override event Action<bool>?          FocusChanged;
	
	protected override bool CoreIsVisible {
		get;
		set;
	}
	protected override Vector2D<int> CorePosition {
		get;
		set;
	}
	protected override string CoreTitle {
		get;
		set;
	}
	protected override WindowState CoreWindowState {
		get;
		set;
	}
	protected override WindowBorder CoreWindowBorder {
		get;
		set;
	}
	protected override bool IsClosingSettable {
		set => throw new NotImplementedException();
	}
	protected override Vector2D<int> SizeSettable {
		set => throw new NotImplementedException();
	}
	protected override Rectangle<int> CoreBorderSize {
		get;
	}
	protected override void CoreInitialize(WindowOptions opts) {
		int result;

		this._isClosing = false;
		
		if (opts.API.API == ContextAPI.Vulkan)
			throw new NotSupportedException();
		
		this.Display = X11Provider.InitOrGetX11Display();

		int defaultScreen = Xlib.DefaultScreen(this.Display);

		List<string> requiredGlxExtensions = new();
		
		Visual* visual = null;

		if (opts.API.API is ContextAPI.OpenGL or ContextAPI.OpenGLES) {
			requiredGlxExtensions.Add("GLX_EXT_swap_control");
			
			List<int> attributes = new();
			attributes.Add(glX.GLX_RGBA);

			// attributes.Add(glX.GLX_DOUBLEBUFFER); 
			// attributes.Add(glX.GLX_NONE);

			if (opts.PreferredDepthBufferBits.HasValue) {
				attributes.Add(glX.GLX_DEPTH_SIZE);
				attributes.Add(opts.PreferredDepthBufferBits.Value);
			}
			if (opts.PreferredStencilBufferBits.HasValue) {
				attributes.Add(glX.GLX_STENCIL_SIZE);
				attributes.Add(opts.PreferredStencilBufferBits.Value);
			}

			int[] att = attributes.ToArray();
			
			fixed(int* attPtr = att) {
				XVisualInfo* visualInfo = glX.glXChooseVisual(this.Display, defaultScreen, attPtr);

				this.VisualInfo = visualInfo;
				if (this.VisualInfo == null) {
					throw new PlatformException("No suitable visual found, check your PrefferedDepthBufferBits and PrefferedStencilBufferBits!");
				}
				
				visual = this.VisualInfo->visual;
			}
		}
		else {
			visual = Xlib.DefaultVisual(this.Display, defaultScreen);
		}

		if (visual == null)
			throw new PlatformException("No suitable visual found!");

		#region Check for GLX extensions
		sbyte* glxExtensions          = glX.glXQueryExtensionsString(this.Display, defaultScreen);
		string availableGlxExtensions = SilkMarshal.PtrToString((nint)glxExtensions)!;
		
		foreach (string extension in requiredGlxExtensions) {
			if(!availableGlxExtensions.Contains(extension))
				throw new PlatformException($"Required GLX extension {extension} not found!");
		}
		Xlib.XFree(glxExtensions);
		#endregion
		
		Window rootWindow = Xlib.RootWindow(this.Display, defaultScreen);
		
		Colormap colorMap = Xlib.XCreateColormap(this.Display, rootWindow, visual, Xlib.AllocNone);

		XSetWindowAttributes windowAttributes = new() {
			colormap   = colorMap,
			event_mask = Xlib.KeyPressMask | Xlib.KeyReleaseMask | Xlib.StructureNotifyMask
		};

		int depth = this.VisualInfo == null ? (int)Xlib.CopyFromParent : this.VisualInfo->depth;
		
		this.Window = Xlib.XCreateWindow(this.Display, rootWindow, opts.Position.X, opts.Position.Y, (uint)opts.Size.X, (uint)opts.Size.Y, 0, depth, Xlib.InputOutput, visual, (nuint)(Xlib.CWColormap | Xlib.CWEventMask), &windowAttributes);

		if (this.Window == Window.NULL)
			throw new PlatformException();

		// if (result != 0)
		// throw new PlatformException();
		
		result = Xlib.XMapWindow(this.Display, this.Window);

		// if (result != 0)
		// throw new PlatformException();

		nint ptr            = SilkMarshal.StringToPtr("WM_DELETE_WINDOW");
		Atom wmDeleteWindow = Xlib.XInternAtom(this.Display, (sbyte*)ptr, 0);
		SilkMarshal.FreeString(ptr);
		result               = Xlib.XSetWMProtocols(this.Display, this.Window, &wmDeleteWindow, 1);
		this._wmDeleteWindow = wmDeleteWindow;
		
		// if (result != 0)
		// throw new PlatformException();

		#region set class and class name
		this._windowClass = opts.WindowClass ?? "defaultwindowclass";

		nint classPtr = SilkMarshal.StringToPtr(this._windowClass);
		nint namePtr  = SilkMarshal.StringToPtr(Assembly.GetEntryAssembly()!.FullName);

		XClassHint* classHint = Xlib.XAllocClassHint();
		classHint->res_class = (sbyte*)classPtr;
		classHint->res_name  = (sbyte*)namePtr;
		Xlib.XSetClassHint(this.Display, this.Window, classHint);
		Xlib.XFree(classHint);
		
		SilkMarshal.FreeString(classPtr);
		SilkMarshal.FreeString(namePtr);
		#endregion
		
		#region set window title
		nint titlePtr = SilkMarshal.StringToPtr(opts.Title);

		Xlib.XStoreName(this.Display, this.Window, (sbyte*)titlePtr);
		
		SilkMarshal.FreeString(titlePtr);
		#endregion

		this._native = new X11NativeWindow(this.Display, this.Window);

		this.CoreSize      = opts.Size;
		this.IsInitialized = true;
	}
	public override event Action<Vector2D<int>>? Move;
	public override event Action<WindowState>?   StateChanged;
	public override event Action<string[]>?      FileDrop;
	public override IWindow                      CreateWindow(WindowOptions opts) => new X11Window(opts);
	public override void SetWindowIcon(ReadOnlySpan<RawImage> icons) {
		throw new NotImplementedException();
	}
	public override IWindowHost? Parent {
		get;
	}
	public override IMonitor? Monitor {
		get;
		set;
	}
	public override IGLContext? SharedContext {
		get;
	}
	public override string? WindowClass {
		get;
	}
}
