using Silk.NET.Core.Contexts;
using TerraFX.Interop.Xlib;

namespace Silk.NET.X11; 

public unsafe class X11NativeWindow : INativeWindow {
	private readonly Display*          _display;
	private readonly Window            _window;
	public           NativeWindowFlags Kind => NativeWindowFlags.X11;

	public X11NativeWindow(Display* display, Window window) {
		this._display = display;
		this._window  = window;
	}
	
	public (nint Display, nuint Window)? X11     => new((nint)this._display, this._window);
	
	public nint?                                                                       Cocoa   => 0;
	public (nint Display, nint Surface)?                                               Wayland => new();
	public nint?                                                                       WinRT   => 0;
	public (nint Window, uint Framebuffer, uint Colorbuffer, uint ResolveFramebuffer)? UIKit   => new();
	public (nint Hwnd, nint HDC, nint HInstance)?                                      Win32   => new();
	public (nint Display, nint Window)?                                                Vivante => new();
	public (nint Window, nint Surface)?                                                Android => new();
	public nint?                                                                       Glfw    => new();
	public nint?                                                                       Sdl     => new();
}
