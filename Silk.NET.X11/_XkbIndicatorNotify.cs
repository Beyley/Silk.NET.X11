namespace Silk.NET.X11
{
    public unsafe partial struct _XkbIndicatorNotify
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

        [NativeTypeName("unsigned int")]
        public uint changed;

        [NativeTypeName("unsigned int")]
        public uint state;
    }
}
