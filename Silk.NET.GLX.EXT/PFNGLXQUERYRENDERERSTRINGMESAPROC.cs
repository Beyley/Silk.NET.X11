using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("const char *")]
    public unsafe delegate sbyte* PFNGLXQUERYRENDERERSTRINGMESAPROC([NativeTypeName("Display *")] Display* dpy, int screen, int renderer, int attribute);
}
