using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("__GLXextFuncPtr")]
    public unsafe delegate IntPtr PFNGLXGETPROCADDRESSPROC([NativeTypeName("const GLubyte *")] byte* procName);
}
