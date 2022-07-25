namespace Silk.NET.X11
{
    public unsafe partial struct XConfigureRequestEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint parent;

        [NativeTypeName("Window")]
        public nuint window;

        public int x;

        public int y;

        public int width;

        public int height;

        public int border_width;

        [NativeTypeName("Window")]
        public nuint above;

        public int detail;

        [NativeTypeName("unsigned long")]
        public nuint value_mask;
    }
}
