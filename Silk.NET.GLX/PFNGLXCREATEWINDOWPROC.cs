using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXWindow")]
    public unsafe delegate UIntPtr PFNGLXCREATEWINDOWPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, [NativeTypeName("Window")] UIntPtr win, [NativeTypeName("const int *")] int* attrib_list);
}
