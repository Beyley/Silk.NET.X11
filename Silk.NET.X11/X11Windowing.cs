using Silk.NET.Windowing;

namespace Silk.NET.X11; 

public static class X11Windowing {
	public static void RegisterPlatform() => X11Platform.GetOrRegister();
	
	/// <summary>
	/// Gets a value indicating whether the given view is an SDL view.
	/// </summary>
	/// <returns>Whether the given view is an SDL view.</returns>
	public static bool IsViewX11(IView view) => view is X11View;
}
