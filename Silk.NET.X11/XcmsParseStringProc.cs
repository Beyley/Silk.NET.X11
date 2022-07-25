using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int XcmsParseStringProc([NativeTypeName("char *")] sbyte* param0, XcmsColor* param1);
}
