namespace Silk.NET.X11
{
    public unsafe partial struct _XkbActionMessage
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

        [NativeTypeName("KeyCode")]
        public byte keycode;

        public int press;

        public int key_event_follows;

        public int group;

        [NativeTypeName("unsigned int")]
        public uint mods;

        [NativeTypeName("char[7]")]
        public fixed sbyte message[7];
    }
}
