using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXRELEASEVIDEOCAPTUREDEVICENVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXVideoCaptureDeviceNV")] UIntPtr device);
}