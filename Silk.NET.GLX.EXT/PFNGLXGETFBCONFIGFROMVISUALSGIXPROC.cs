using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXFBConfigSGIX")]
    public unsafe delegate __GLXFBConfigRec* PFNGLXGETFBCONFIGFROMVISUALSGIXPROC([NativeTypeName("Display *")] Display* dpy, XVisualInfo* vis);
}
