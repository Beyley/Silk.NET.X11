using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXBINDVIDEOIMAGENVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXVideoDeviceNV")] uint VideoDevice, [NativeTypeName("GLXPbuffer")] UIntPtr pbuf, int iVideoBuffer);
}
