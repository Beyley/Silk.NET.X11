using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXDELETEASSOCIATEDCONTEXTAMDPROC([NativeTypeName("GLXContext")] __GLXcontextRec* ctx);
}
