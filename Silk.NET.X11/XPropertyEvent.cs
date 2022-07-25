namespace Silk.NET.X11
{
    public unsafe partial struct XPropertyEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("Atom")]
        public nuint atom;

        [NativeTypeName("Time")]
        public nuint time;

        public int state;
    }
}
