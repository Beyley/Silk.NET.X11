using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int XcmsDDConversionProc([NativeTypeName("XcmsCCC")] _XcmsCCC* param0, XcmsColor* param1, [NativeTypeName("unsigned int")] uint param2, int* param3);
}
