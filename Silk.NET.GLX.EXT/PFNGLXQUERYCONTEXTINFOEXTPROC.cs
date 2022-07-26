using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYCONTEXTINFOEXTPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* context, int attribute, int* value);
}
