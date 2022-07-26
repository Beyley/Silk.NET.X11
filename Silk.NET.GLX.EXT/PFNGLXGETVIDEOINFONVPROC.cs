using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXGETVIDEOINFONVPROC([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("GLXVideoDeviceNV")] uint VideoDevice, [NativeTypeName("unsigned long *")] UIntPtr* pulCounterOutputPbuffer, [NativeTypeName("unsigned long *")] UIntPtr* pulCounterOutputVideo);
}
