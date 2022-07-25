using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void XIMProc([NativeTypeName("XIM")] _XIM* param0, [NativeTypeName("XPointer")] sbyte* param1, [NativeTypeName("XPointer")] sbyte* param2);
}
