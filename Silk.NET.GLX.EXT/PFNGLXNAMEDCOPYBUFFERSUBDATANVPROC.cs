using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXNAMEDCOPYBUFFERSUBDATANVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* readCtx, [NativeTypeName("GLXContext")] __GLXcontextRec* writeCtx, [NativeTypeName("GLuint")] uint readBuffer, [NativeTypeName("GLuint")] uint writeBuffer, [NativeTypeName("GLintptr")] IntPtr readOffset, [NativeTypeName("GLintptr")] IntPtr writeOffset, [NativeTypeName("GLsizeiptr")] IntPtr size);
}
