using System;
using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    public partial struct XcmsColor
    {
        [NativeTypeName("union (anonymous union at Xcms.h:176:5)")]
        public _spec_e__Union spec;

        [NativeTypeName("unsigned long")]
        public UIntPtr pixel;

        [NativeTypeName("XcmsColorFormat")]
        public UIntPtr format;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _spec_e__Union
        {
            [FieldOffset(0)]
            public XcmsRGB RGB;

            [FieldOffset(0)]
            public XcmsRGBi RGBi;

            [FieldOffset(0)]
            public XcmsCIEXYZ CIEXYZ;

            [FieldOffset(0)]
            public XcmsCIEuvY CIEuvY;

            [FieldOffset(0)]
            public XcmsCIExyY CIExyY;

            [FieldOffset(0)]
            public XcmsCIELab CIELab;

            [FieldOffset(0)]
            public XcmsCIELuv CIELuv;

            [FieldOffset(0)]
            public XcmsTekHVC TekHVC;

            [FieldOffset(0)]
            public XcmsPad Pad;
        }
    }
}
