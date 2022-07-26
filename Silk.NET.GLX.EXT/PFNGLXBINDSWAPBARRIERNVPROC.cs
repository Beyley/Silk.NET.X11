using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXBINDSWAPBARRIERNVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLuint")] uint group, [NativeTypeName("GLuint")] uint barrier);
}
