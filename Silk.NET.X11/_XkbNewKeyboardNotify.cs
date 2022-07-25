namespace Silk.NET.X11
{
    public unsafe partial struct _XkbNewKeyboardNotify
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

        public int old_device;

        public int min_key_code;

        public int max_key_code;

        public int old_min_key_code;

        public int old_max_key_code;

        [NativeTypeName("unsigned int")]
        public uint changed;

        [NativeTypeName("char")]
        public sbyte req_major;

        [NativeTypeName("char")]
        public sbyte req_minor;
    }
}
