using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void XConnectionWatchProc([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XPointer")] sbyte* param1, int param2, int param3, [NativeTypeName("XPointer *")] sbyte** param4);
}
