using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXMAKECURRENTREADSGIPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr draw, [NativeTypeName("GLXDrawable")] UIntPtr read, [NativeTypeName("GLXContext")] __GLXcontextRec* ctx);
}
