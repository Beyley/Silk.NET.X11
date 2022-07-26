using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXGETTRANSPARENTINDEXSUNPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("Window")] UIntPtr overlay, [NativeTypeName("Window")] UIntPtr underlay, [NativeTypeName("unsigned long *")] UIntPtr* pTransparentIndex);
}
