using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.GLX;
using Silk.NET.GLX.EXT;
using TerraFX.Interop.Xlib;

namespace Silk.NET.X11; 

public unsafe class X11GLContext : IGLContext {
	private readonly X11Window        _window;
	private          __GLXcontextRec* _glContext;

	public X11GLContext(X11Window window) {
		this._window = window;

		this._glContext = glX.glXCreateContext(window.Display, window.VisualInfo, null, 1);
	}
	
	public void Dispose() {
		glX.glXDestroyContext(this._window.Display, this._glContext);

		this._glContext = null;
	}
	public unsafe nint GetProcAddress(string proc, int? slot = null) {
		// throw new NotImplementedException();

		byte*  ptr  = (byte*)SilkMarshal.StringToPtr(proc);
		IntPtr addr = glX.glXGetProcAddress(ptr);
		SilkMarshal.FreeString((nint)ptr);

		return addr;
	}
	public bool TryGetProcAddress(string proc, out nint addr, int? slot = null) {
		addr = this.GetProcAddress(proc, slot);

		return addr != 0;
	}
	public void SwapInterval(int interval) {
		//fuck vsync all my homies hate vsync
		// glXExt.glXSwapIntervalEXT(this._window.Display, this._window.Window, interval);
	}
	public void SwapBuffers() {
		glX.glXSwapBuffers(this._window.Display, this._window.Window);
	}
	public void MakeCurrent() {
		glX.glXMakeCurrent(this._window.Display, this._window.Window, this._glContext);
	}
	public void Clear() {
		
	}
	public nint Handle {
		get;
	}
	public IGLContextSource? Source {
		get;
	}
	public bool IsCurrent {
		get;
	}
}
