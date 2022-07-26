using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXFBConfigSGIX *")]
    public unsafe delegate __GLXFBConfigRec** PFNGLXCHOOSEFBCONFIGSGIXPROC([NativeTypeName("Display *")] Display* dpy, int screen, int* attrib_list, int* nelements);
}
