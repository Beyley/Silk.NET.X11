using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLboolean")]
    public delegate byte PFNGLXSET3DFXMODEMESAPROC([NativeTypeName("GLint")] int mode);
}
