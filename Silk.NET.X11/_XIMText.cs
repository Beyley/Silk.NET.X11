using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    public unsafe partial struct _XIMText
    {
        [NativeTypeName("unsigned short")]
        public ushort length;

        [NativeTypeName("XIMFeedback *")]
        public nuint* feedback;

        public int encoding_is_wchar;

        [NativeTypeName("union (anonymous union at Xlib.h:1261:5)")]
        public _string_e__Union @string;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _string_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("char *")]
            public sbyte* multi_byte;

            [FieldOffset(0)]
            [NativeTypeName("wchar_t *")]
            public int* wide_char;
        }
    }
}
