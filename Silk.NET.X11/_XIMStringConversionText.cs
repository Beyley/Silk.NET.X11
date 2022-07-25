using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    public unsafe partial struct _XIMStringConversionText
    {
        [NativeTypeName("unsigned short")]
        public ushort length;

        [NativeTypeName("XIMStringConversionFeedback *")]
        public nuint* feedback;

        public int encoding_is_wchar;

        [NativeTypeName("union (anonymous union at Xlib.h:1295:5)")]
        public _string_e__Union @string;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _string_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("char *")]
            public sbyte* mbs;

            [FieldOffset(0)]
            [NativeTypeName("wchar_t *")]
            public int* wcs;
        }
    }
}
