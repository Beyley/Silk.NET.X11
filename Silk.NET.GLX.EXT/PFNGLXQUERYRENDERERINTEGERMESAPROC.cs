using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYRENDERERINTEGERMESAPROC([NativeTypeName("Display *")] Display* dpy, int screen, int renderer, int attribute, [NativeTypeName("unsigned int *")] uint* value);
}
