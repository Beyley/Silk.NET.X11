using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXBINDVIDEODEVICENVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("unsigned int")] uint video_slot, [NativeTypeName("unsigned int")] uint video_device, [NativeTypeName("const int *")] int* attrib_list);
}
