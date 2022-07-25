using System;
using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int XcmsWhiteAdjustProc([NativeTypeName("XcmsCCC")] _XcmsCCC* param0, XcmsColor* param1, XcmsColor* param2, [NativeTypeName("XcmsColorFormat")] UIntPtr param3, XcmsColor* param4, [NativeTypeName("unsigned int")] uint param5, int* param6);
}
