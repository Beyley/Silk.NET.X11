namespace Silk.NET.X11
{
    public unsafe partial struct XMapEvent
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

        public int override_redirect;
    }
}
