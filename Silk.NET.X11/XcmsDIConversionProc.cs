using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int XcmsDIConversionProc([NativeTypeName("XcmsCCC")] _XcmsCCC* param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("unsigned int")] uint param3);
}
