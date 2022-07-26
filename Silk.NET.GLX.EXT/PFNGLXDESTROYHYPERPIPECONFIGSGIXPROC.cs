using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXDESTROYHYPERPIPECONFIGSGIXPROC([NativeTypeName("Display *")] Display* dpy, int hpId);
}
