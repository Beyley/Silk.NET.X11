using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXRELEASEVIDEODEVICENVPROC([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("GLXVideoDeviceNV")] uint VideoDevice);
}
