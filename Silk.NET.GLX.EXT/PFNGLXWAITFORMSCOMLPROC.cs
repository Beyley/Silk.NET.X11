using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXWAITFORMSCOMLPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("int64_t")] IntPtr target_msc, [NativeTypeName("int64_t")] IntPtr divisor, [NativeTypeName("int64_t")] IntPtr remainder, [NativeTypeName("int64_t *")] IntPtr* ust, [NativeTypeName("int64_t *")] IntPtr* msc, [NativeTypeName("int64_t *")] IntPtr* sbc);
}
