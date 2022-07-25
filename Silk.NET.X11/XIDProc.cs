using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void XIDProc([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XPointer")] sbyte* param1, [NativeTypeName("XPointer")] sbyte* param2);
}
