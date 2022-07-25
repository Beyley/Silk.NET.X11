using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.Windowing;
using Silk.NET.X11;
using TerraFX.Interop.Xlib;
using Window = Silk.NET.Windowing.Window;

X11Platform.GetOrRegister();

WindowOptions options = WindowOptions.Default;

options.Size = new Vector2D<int>(800, 600);

X11Window window = (X11Window)Window.Create(options);

window.Load += () => {
	Console.WriteLine($"Window loading!");
};
window.Closing += () => {
	Console.WriteLine("Window Closing");
};

window.Render += d => {
	unsafe {
		// int  length = "Test Draw!".Length;
		
		// Xlib.XDrawString(window._display, new Drawable(window._window), Xlib.DefaultGC(window._display, Xlib.DefaultScreen(window._display)), 10, 10, (sbyte*)ptr, length);
	}
};
window.Update += d => {};

window.Run();
