using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXContextID")]
    public unsafe delegate UIntPtr PFNGLXGETCONTEXTIDEXTPROC([NativeTypeName("const GLXContext")] __GLXcontextRec* context);
}
