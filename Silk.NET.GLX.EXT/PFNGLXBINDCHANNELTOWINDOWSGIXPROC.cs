using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXBINDCHANNELTOWINDOWSGIXPROC([NativeTypeName("Display *")] Display* display, int screen, int channel, [NativeTypeName("Window")] UIntPtr window);
}
