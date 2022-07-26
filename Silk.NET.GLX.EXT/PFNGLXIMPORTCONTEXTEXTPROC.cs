using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXContext")]
    public unsafe delegate __GLXcontextRec* PFNGLXIMPORTCONTEXTEXTPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContextID")] UIntPtr contextID);
}
