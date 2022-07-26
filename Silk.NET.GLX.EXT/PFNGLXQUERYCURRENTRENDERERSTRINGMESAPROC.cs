using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("const char *")]
    public unsafe delegate sbyte* PFNGLXQUERYCURRENTRENDERERSTRINGMESAPROC(int attribute);
}
