using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    public partial struct _XIMStatusDrawCallbackStruct
    {
        public XIMStatusDataType type;

        [NativeTypeName("union (anonymous union at Xlib.h:1359:5)")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("XIMText *")]
            public _XIMText* text;

            [FieldOffset(0)]
            [NativeTypeName("Pixmap")]
            public nuint bitmap;
        }
    }
}
