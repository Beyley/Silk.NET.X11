using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYCHANNELRECTSGIXPROC([NativeTypeName("Display *")] Display* display, int screen, int channel, int* dx, int* dy, int* dw, int* dh);
}
