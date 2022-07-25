using System.Runtime.InteropServices;
using Silk.NET.Windowing;

namespace Silk.NET.X11; 

public class X11Platform : IWindowPlatform {
	public static X11Platform GetOrRegister()
	{
		X11Platform? val = Window.GetOrDefault<X11Platform>();
		
		if (val is null)
		{
			Window.Add(val = new X11Platform());
		}

		return val;
	}
	
	public IWindow CreateWindow(WindowOptions opts) {
		return new X11Window(opts);
	}
	
	public IView GetView(ViewOptions? opts = null) {
		opts ??= ViewOptions.Default;

		X11View view = new(opts.Value);

		return view;
	}
	
	public void ClearContexts() {
		// throw new NotImplementedException();
	}
	
	public IEnumerable<IMonitor> GetMonitors() {
		throw new NotImplementedException();
	}
	
	public IMonitor GetMainMonitor() {
		throw new NotImplementedException();
	}
	
	public bool IsSourceOfView(IView view) => view is X11View;

	public bool IsViewOnly => false;
	public bool IsApplicable => RuntimeInformation.IsOSPlatform(OSPlatform.Linux); //TODO: detect whether we should use GLFW for Wayland instead
}
