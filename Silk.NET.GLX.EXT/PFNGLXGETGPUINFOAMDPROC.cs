using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXGETGPUINFOAMDPROC([NativeTypeName("unsigned int")] uint id, int property, [NativeTypeName("GLenum")] uint dataType, [NativeTypeName("unsigned int")] uint size, void* data);
}
