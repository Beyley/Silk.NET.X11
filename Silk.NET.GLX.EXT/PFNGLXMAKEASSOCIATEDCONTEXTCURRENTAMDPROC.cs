using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXMAKEASSOCIATEDCONTEXTCURRENTAMDPROC([NativeTypeName("GLXContext")] __GLXcontextRec* ctx);
}
