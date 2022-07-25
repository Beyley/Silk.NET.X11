namespace Silk.NET.X11
{
    public unsafe partial struct _XkbBellNotify
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Time")]
        public nuint time;

        public int xkb_type;

        public int device;

        public int percent;

        public int pitch;

        public int duration;

        public int bell_class;

        public int bell_id;

        [NativeTypeName("Atom")]
        public nuint name;

        [NativeTypeName("Window")]
        public nuint window;

        public int event_only;
    }
}
