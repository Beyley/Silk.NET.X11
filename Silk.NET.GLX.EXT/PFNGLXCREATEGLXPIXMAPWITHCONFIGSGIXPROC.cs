using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXPixmap")]
    public unsafe delegate UIntPtr PFNGLXCREATEGLXPIXMAPWITHCONFIGSGIXPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config, [NativeTypeName("Pixmap")] UIntPtr pixmap);
}
