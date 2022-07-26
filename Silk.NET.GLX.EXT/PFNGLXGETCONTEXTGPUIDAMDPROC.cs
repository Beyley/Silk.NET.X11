using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("unsigned int")]
    public unsafe delegate uint PFNGLXGETCONTEXTGPUIDAMDPROC([NativeTypeName("GLXContext")] __GLXcontextRec* ctx);
}
