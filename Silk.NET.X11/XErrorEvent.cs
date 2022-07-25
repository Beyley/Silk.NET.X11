namespace Silk.NET.X11
{
    public unsafe partial struct XErrorEvent
    {
        public int type;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("XID")]
        public nuint resourceid;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        [NativeTypeName("unsigned char")]
        public byte error_code;

        [NativeTypeName("unsigned char")]
        public byte request_code;

        [NativeTypeName("unsigned char")]
        public byte minor_code;
    }
}
