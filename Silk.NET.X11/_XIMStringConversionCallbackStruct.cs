namespace Silk.NET.X11
{
    public unsafe partial struct _XIMStringConversionCallbackStruct
    {
        [NativeTypeName("XIMStringConversionPosition")]
        public ushort position;

        public XIMCaretDirection direction;

        [NativeTypeName("XIMStringConversionOperation")]
        public ushort operation;

        [NativeTypeName("unsigned short")]
        public ushort factor;

        [NativeTypeName("XIMStringConversionText *")]
        public _XIMStringConversionText* text;
    }
}
