using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXContext")]
    public unsafe delegate __GLXcontextRec* PFNGLXCREATEASSOCIATEDCONTEXTATTRIBSAMDPROC([NativeTypeName("unsigned int")] uint id, [NativeTypeName("GLXContext")] __GLXcontextRec* share_context, [NativeTypeName("const int *")] int* attribList);
}
