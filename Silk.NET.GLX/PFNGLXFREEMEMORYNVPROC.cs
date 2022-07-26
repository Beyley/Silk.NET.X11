using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXFREEMEMORYNVPROC([NativeTypeName("GLvoid *")] void* pointer);
}
