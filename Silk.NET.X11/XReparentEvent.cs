namespace Silk.NET.X11
{
    public unsafe partial struct XReparentEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint @event;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("Window")]
        public nuint parent;

        public int x;

        public int y;

        public int override_redirect;
    }
}
