using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXPbufferSGIX")]
    public unsafe delegate UIntPtr PFNGLXCREATEGLXPBUFFERSGIXPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int* attrib_list);
}
