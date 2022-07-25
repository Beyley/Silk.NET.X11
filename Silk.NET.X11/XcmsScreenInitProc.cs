using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int XcmsScreenInitProc([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("XcmsPerScrnInfo *")] _XcmsPerScrnInfo* param2);
}
