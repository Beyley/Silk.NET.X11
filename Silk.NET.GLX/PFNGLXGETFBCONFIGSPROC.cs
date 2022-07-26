using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXFBConfig *")]
    public unsafe delegate __GLXFBConfigRec** PFNGLXGETFBCONFIGSPROC([NativeTypeName("Display *")] Display* dpy, int screen, int* nelements);
}
