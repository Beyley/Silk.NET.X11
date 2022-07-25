namespace Silk.NET.X11
{
    public unsafe partial struct XGraphicsExposeEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Drawable")]
        public nuint drawable;

        public int x;

        public int y;

        public int width;

        public int height;

        public int count;

        public int major_code;

        public int minor_code;
    }
}
