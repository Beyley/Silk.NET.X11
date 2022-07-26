using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("unsigned int")]
    public unsafe delegate uint PFNGLXGETGPUIDSAMDPROC([NativeTypeName("unsigned int")] uint maxCount, [NativeTypeName("unsigned int *")] uint* ids);
}
