using System;

namespace Silk.NET.X11
{
    public unsafe partial struct _XcmsCCC
    {
        [NativeTypeName("Display *")]
        public _XDisplay* dpy;

        public int screenNumber;

        public Visual* visual;

        public XcmsColor clientWhitePt;

        [NativeTypeName("XcmsCompressionProc")]
        public IntPtr gamutCompProc;

        [NativeTypeName("XPointer")]
        public sbyte* gamutCompClientData;

        [NativeTypeName("XcmsWhiteAdjustProc")]
        public IntPtr whitePtAdjProc;

        [NativeTypeName("XPointer")]
        public sbyte* whitePtAdjClientData;

        [NativeTypeName("XcmsPerScrnInfo *")]
        public _XcmsPerScrnInfo* pPerScrnInfo;
    }
}
