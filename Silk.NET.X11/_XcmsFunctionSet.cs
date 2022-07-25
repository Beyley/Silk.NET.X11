using System;

namespace Silk.NET.X11
{
    public unsafe partial struct _XcmsFunctionSet
    {
        [NativeTypeName("XcmsColorSpace **")]
        public _XcmsColorSpace** DDColorSpaces;

        [NativeTypeName("XcmsScreenInitProc")]
        public IntPtr screenInitProc;

        [NativeTypeName("XcmsScreenFreeProc")]
        public IntPtr screenFreeProc;
    }
}
