using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXCHANNELRECTSGIXPROC([NativeTypeName("Display *")] Display* display, int screen, int channel, int x, int y, int w, int h);
}
