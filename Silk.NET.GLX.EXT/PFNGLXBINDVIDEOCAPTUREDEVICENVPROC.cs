using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXBINDVIDEOCAPTUREDEVICENVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("unsigned int")] uint video_capture_slot, [NativeTypeName("GLXVideoCaptureDeviceNV")] UIntPtr device);
}
