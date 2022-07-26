using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXPixmap")]
    public unsafe delegate UIntPtr PFNGLXCREATEGLXPIXMAPMESAPROC([NativeTypeName("Display *")] Display* dpy, XVisualInfo* visual, [NativeTypeName("Pixmap")] UIntPtr pixmap, [NativeTypeName("Colormap")] UIntPtr cmap);
}
