using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXRELEASEVIDEOIMAGENVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbuffer")] UIntPtr pbuf);
}
