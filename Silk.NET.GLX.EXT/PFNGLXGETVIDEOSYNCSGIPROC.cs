using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXGETVIDEOSYNCSGIPROC([NativeTypeName("unsigned int *")] uint* count);
}
