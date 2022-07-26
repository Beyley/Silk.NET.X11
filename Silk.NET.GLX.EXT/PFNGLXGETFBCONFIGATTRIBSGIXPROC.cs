using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXGETFBCONFIGATTRIBSGIXPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config, int attribute, int* value);
}
