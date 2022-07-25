using System;

namespace Silk.NET.X11
{
    public unsafe partial struct _XcmsColorSpace
    {
        [NativeTypeName("const char *")]
        public sbyte* prefix;

        [NativeTypeName("XcmsColorFormat")]
        public UIntPtr id;

        [NativeTypeName("XcmsParseStringProc")]
        public IntPtr parseString;

        [NativeTypeName("XcmsFuncListPtr")]
        public IntPtr* to_CIEXYZ;

        [NativeTypeName("XcmsFuncListPtr")]
        public IntPtr* from_CIEXYZ;

        public int inverse_flag;
    }
}
