using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("unsigned int *")]
    public unsafe delegate uint* PFNGLXENUMERATEVIDEODEVICESNVPROC([NativeTypeName("Display *")] Display* dpy, int screen, int* nelements);
}
