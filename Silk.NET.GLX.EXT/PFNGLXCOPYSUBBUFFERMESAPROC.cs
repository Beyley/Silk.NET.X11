using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXCOPYSUBBUFFERMESAPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, int x, int y, int width, int height);
}
