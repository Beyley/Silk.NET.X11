using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXFBConfig *")]
    public unsafe delegate __GLXFBConfigRec** PFNGLXCHOOSEFBCONFIGPROC([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("const int *")] int* attrib_list, int* nelements);
}
