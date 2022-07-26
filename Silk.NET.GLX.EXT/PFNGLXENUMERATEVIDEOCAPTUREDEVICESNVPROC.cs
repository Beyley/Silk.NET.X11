using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXVideoCaptureDeviceNV *")]
    public unsafe delegate UIntPtr* PFNGLXENUMERATEVIDEOCAPTUREDEVICESNVPROC([NativeTypeName("Display *")] Display* dpy, int screen, int* nelements);
}
