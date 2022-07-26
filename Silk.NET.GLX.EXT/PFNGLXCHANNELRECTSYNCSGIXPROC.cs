using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXCHANNELRECTSYNCSGIXPROC([NativeTypeName("Display *")] Display* display, int screen, int channel, [NativeTypeName("GLenum")] uint synctype);
}
