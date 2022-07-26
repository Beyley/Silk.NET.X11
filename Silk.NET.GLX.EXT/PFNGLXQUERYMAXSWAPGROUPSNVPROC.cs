using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYMAXSWAPGROUPSNVPROC([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("GLuint *")] uint* maxGroups, [NativeTypeName("GLuint *")] uint* maxBarriers);
}
