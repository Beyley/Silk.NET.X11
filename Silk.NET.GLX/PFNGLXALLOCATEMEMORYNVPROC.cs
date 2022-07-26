using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* PFNGLXALLOCATEMEMORYNVPROC([NativeTypeName("GLsizei")] int size, [NativeTypeName("GLfloat")] float readfreq, [NativeTypeName("GLfloat")] float writefreq, [NativeTypeName("GLfloat")] float priority);
}
