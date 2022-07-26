using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXPixmap")]
    public unsafe delegate UIntPtr PFNGLXCREATEPIXMAPPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, [NativeTypeName("Pixmap")] UIntPtr pixmap, [NativeTypeName("const int *")] int* attrib_list);
}
