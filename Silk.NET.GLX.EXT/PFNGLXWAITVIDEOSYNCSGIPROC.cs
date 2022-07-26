using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXWAITVIDEOSYNCSGIPROC(int divisor, int remainder, [NativeTypeName("unsigned int *")] uint* count);
}
