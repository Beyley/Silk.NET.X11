namespace Silk.NET.X11
{
    public unsafe partial struct XGenericEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        public int extension;

        public int evtype;
    }
}
