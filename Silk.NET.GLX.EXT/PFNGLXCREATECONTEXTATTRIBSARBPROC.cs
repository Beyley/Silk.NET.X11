using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXContext")]
    public unsafe delegate __GLXcontextRec* PFNGLXCREATECONTEXTATTRIBSARBPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, [NativeTypeName("GLXContext")] __GLXcontextRec* share_context, int direct, [NativeTypeName("const int *")] int* attrib_list);
}
