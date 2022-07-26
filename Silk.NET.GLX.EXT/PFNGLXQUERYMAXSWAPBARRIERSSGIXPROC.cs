using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYMAXSWAPBARRIERSSGIXPROC([NativeTypeName("Display *")] Display* dpy, int screen, int* max);
}
