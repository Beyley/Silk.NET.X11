using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXENDFRAMETRACKINGMESAPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable);
}
