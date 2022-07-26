using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("int64_t")]
    public unsafe delegate IntPtr PFNGLXSWAPBUFFERSMSCOMLPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("int64_t")] IntPtr target_msc, [NativeTypeName("int64_t")] IntPtr divisor, [NativeTypeName("int64_t")] IntPtr remainder);
}
