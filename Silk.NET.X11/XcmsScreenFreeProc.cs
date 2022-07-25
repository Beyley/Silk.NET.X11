using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void XcmsScreenFreeProc([NativeTypeName("XPointer")] sbyte* param0);
}
