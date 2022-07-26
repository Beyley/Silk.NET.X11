using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.GLX;

namespace Silk.NET.X11; 

public class X11GLContext : IGLContext {
	private readonly X11Window _window;
	
	public X11GLContext(X11Window window) {
		this._window = window;
	}
	
	public void Dispose() {
		// throw new NotImplementedException();
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
		
	}
	public void SwapBuffers() {
		
	}
	public void MakeCurrent() {
		
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
