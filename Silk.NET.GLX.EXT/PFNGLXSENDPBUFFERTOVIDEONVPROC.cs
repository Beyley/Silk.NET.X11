using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXSENDPBUFFERTOVIDEONVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbuffer")] UIntPtr pbuf, int iBufferType, [NativeTypeName("unsigned long *")] UIntPtr* pulCounterPbuffer, [NativeTypeName("GLboolean")] byte bBlock);
}
