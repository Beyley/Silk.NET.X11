using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYVIDEOCAPTUREDEVICENVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXVideoCaptureDeviceNV")] UIntPtr device, int attribute, int* value);
}
