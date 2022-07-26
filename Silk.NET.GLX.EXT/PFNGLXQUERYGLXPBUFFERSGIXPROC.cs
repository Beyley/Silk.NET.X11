using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXQUERYGLXPBUFFERSGIXPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbufferSGIX")] UIntPtr pbuf, int attribute, [NativeTypeName("unsigned int *")] uint* value);
}