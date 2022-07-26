using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXCOPYBUFFERSUBDATANVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* readCtx, [NativeTypeName("GLXContext")] __GLXcontextRec* writeCtx, [NativeTypeName("GLenum")] uint readTarget, [NativeTypeName("GLenum")] uint writeTarget, [NativeTypeName("GLintptr")] IntPtr readOffset, [NativeTypeName("GLintptr")] IntPtr writeOffset, [NativeTypeName("GLsizeiptr")] IntPtr size);
}
