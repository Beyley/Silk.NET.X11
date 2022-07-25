namespace Silk.NET.X11
{
    public unsafe partial struct XKeymapEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("char[32]")]
        public fixed sbyte key_vector[32];
    }
}
