using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("GLXDrawable")]
    public delegate UIntPtr PFNGLXGETCURRENTREADDRAWABLEPROC();
}
