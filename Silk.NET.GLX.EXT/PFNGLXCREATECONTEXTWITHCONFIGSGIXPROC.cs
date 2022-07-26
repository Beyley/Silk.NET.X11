using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXContext")]
    public unsafe delegate __GLXcontextRec* PFNGLXCREATECONTEXTWITHCONFIGSGIXPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config, int render_type, [NativeTypeName("GLXContext")] __GLXcontextRec* share_list, int direct);
}
