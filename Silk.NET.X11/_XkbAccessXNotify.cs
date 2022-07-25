namespace Silk.NET.X11
{
    public unsafe partial struct _XkbAccessXNotify
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

        public int detail;

        public int keycode;

        public int sk_delay;

        public int debounce_delay;
    }
}
