namespace Silk.NET.X11
{
    public unsafe partial struct XButtonEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("Window")]
        public nuint root;

        [NativeTypeName("Window")]
        public nuint subwindow;

        [NativeTypeName("Time")]
        public nuint time;

        public int x;

        public int y;

        public int x_root;

        public int y_root;

        [NativeTypeName("unsigned int")]
        public uint state;

        [NativeTypeName("unsigned int")]
        public uint button;

        public int same_screen;
    }
}
