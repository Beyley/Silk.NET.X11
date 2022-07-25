using System.Reflection;
using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.Windowing;
using TerraFX.Interop.Xlib;
using Window = TerraFX.Interop.Xlib.Window;

namespace Silk.NET.X11; 

public unsafe class X11Window : WindowImplementationBase {
	public Window   _window;
	public Display* _display;
	
	private Queue<XEvent> _eventQueue = new();
	private INativeWindow _native;
	private Atom          _wmDeleteWindow;
	private string        _windowClass;

	public X11Window(WindowOptions optionsCache) : base(optionsCache) {}
	protected override Vector2D<int> CoreSize {
		get;
	}
	protected override nint CoreHandle {
		get;
	}
	protected override bool CoreIsClosing {
		get;
	}
	protected override IGLContext? CoreGLContext {
		get;
	}
	protected override IVkSurface? CoreVkSurface {
		get;
	}
	protected override void CoreReset() {
		if (this._window == Window.NULL)
			return;

		int result = Xlib.XUnmapWindow(this._display, this._window);
		
		// if (result != 0)
		// throw new PlatformException();
		
		result = Xlib.XDestroyWindow(this._display, this._window);

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
			if (Xlib.XPending(this._display) != 0) {
				if (Xlib.XNextEvent(this._display, &e) != 0)
					throw new PlatformException();

				this._eventQueue.Enqueue(e);
			}
		}
		else {
			while (Xlib.XPending(this._display) != 0) {
				if (Xlib.XNextEvent(this._display, &e) != 0)
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
			Console.WriteLine(e.type);
		}
	}
	public override void ContinueEvents() {
		// throw new NotImplementedException();
	}
	public override void Close() {
		this.Closing?.Invoke();
		this.CoreReset();		
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

		if (opts.API.API == ContextAPI.Vulkan)
			throw new NotSupportedException();
		
		this._display = X11Provider.InitOrGetX11Display();

		int s = Xlib.DefaultScreen(this._display);
		this._window = Xlib.XCreateSimpleWindow(this._display, Xlib.RootWindow(this._display, s), opts.Position.X, opts.Position.Y, (uint)opts.Size.X, (uint)opts.Size.Y, 1, Xlib.BlackPixel(this._display, s), Xlib.BlackPixel(this._display, s));

		if (this._window == Window.NULL)
			throw new PlatformException();

		result = Xlib.XSelectInput(this._display, this._window, Xlib.KeyPressMask | Xlib.KeyReleaseMask);
		
		// if (result != 0)
		// throw new PlatformException();
		
		result = Xlib.XMapWindow(this._display, this._window);

		// if (result != 0)
		// throw new PlatformException();

		nint ptr            = SilkMarshal.StringToPtr("WM_DELETE_WINDOW");
		Atom wmDeleteWindow = Xlib.XInternAtom(this._display, (sbyte*)ptr, 0);
		SilkMarshal.FreeString(ptr);
		result               = Xlib.XSetWMProtocols(this._display, this._window, &wmDeleteWindow, 1);
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
		Xlib.XSetClassHint(this._display, this._window, classHint);
		Xlib.XFree(classHint);
		
		SilkMarshal.FreeString(classPtr);
		SilkMarshal.FreeString(namePtr);
		#endregion
		
		#region set window title
		nint titlePtr = SilkMarshal.StringToPtr(opts.Title);

		Xlib.XStoreName(this._display, this._window, (sbyte*)titlePtr);
		
		SilkMarshal.FreeString(titlePtr);
		#endregion

		this._native = new X11NativeWindow(this._display, this._window);
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
