using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXDESTROYGLXPBUFFERSGIXPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbufferSGIX")] UIntPtr pbuf);
}
