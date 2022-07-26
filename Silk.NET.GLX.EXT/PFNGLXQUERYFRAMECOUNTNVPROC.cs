using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYFRAMECOUNTNVPROC([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("GLuint *")] uint* count);
}
