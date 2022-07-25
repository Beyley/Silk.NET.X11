namespace Silk.NET.X11
{
    public unsafe partial struct XNoExposeEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Drawable")]
        public nuint drawable;

        public int major_code;

        public int minor_code;
    }
}
