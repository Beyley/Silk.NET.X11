using TerraFX.Interop.Xlib;

namespace Silk.NET.X11; 

public static unsafe class X11Provider {
	private static Display* _Display;

	public static Display* InitOrGetX11Display() {
		if (_Display != null)
			return _Display;
		
		_Display = Xlib.XOpenDisplay(null);

		if (_Display == null)
			throw new Exception("Failed to open display!");

		return _Display;
	}

	public static void CloseDisplay() {
		if (_Display == null)
			return;

		int result = Xlib.XCloseDisplay(_Display);

		if (result != 0)
			throw new Exception("Failed to close display!");

		_Display = null;
	}
}
