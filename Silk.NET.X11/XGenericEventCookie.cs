namespace Silk.NET.X11
{
    public unsafe partial struct XGenericEventCookie
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        public int extension;

        public int evtype;

        [NativeTypeName("unsigned int")]
        public uint cookie;

        public void* data;
    }
}
