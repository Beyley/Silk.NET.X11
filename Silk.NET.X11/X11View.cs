using Silk.NET.Core;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Native;
using Silk.NET.Maths;
using Silk.NET.Windowing;
using TerraFX.Interop.Xlib;
using Window = TerraFX.Interop.Xlib.Window;

namespace Silk.NET.X11; 

public unsafe class X11View : ViewImplementationBase {

	public X11View(ViewOptions opts) : base(opts) {
		
	}
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
	protected override void CoreInitialize(ViewOptions opts) {
		
	}
	protected override void CoreReset() {

	}
	public override VideoMode VideoMode {
		get;
	}
	public override bool IsEventDriven {
		get;
		set;
	} = true;
	public override Vector2D<int> FramebufferSize {
		get;
	}

	
	public override void DoEvents() {

	}


	
	public override void ContinueEvents() {
		// throw new NotImplementedException();
	}
	
	public override void Close() {
		// throw new NotImplementedException();
	}
	
	protected override void RegisterCallbacks() {
		// throw new NotImplementedException();
	}
	
	protected override void UnregisterCallbacks() {
		// throw new NotImplementedException();
	}
	
	protected override INativeWindow GetNativeWindow() {
		// throw new NotImplementedException();

		return null;
	}
	
	public override event Action<Vector2D<int>>? Resize;
	public override event Action<Vector2D<int>>? FramebufferResize;
	public override event Action?                Closing;
	public override event Action<bool>?          FocusChanged;
	
	public override Vector2D<int> PointToClient(Vector2D<int> point) {
		// throw new NotImplementedException();
		
		return Vector2D<int>.Zero;
	}
	
	public override Vector2D<int> PointToScreen(Vector2D<int> point) {
		// throw new NotImplementedException();
		
		return Vector2D<int>.Zero;
	}
}
