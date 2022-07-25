namespace Silk.NET.X11
{
    public unsafe partial struct _XkbStateNotifyEvent
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

        public int group;

        public int base_group;

        public int latched_group;

        public int locked_group;

        [NativeTypeName("unsigned int")]
        public uint mods;

        [NativeTypeName("unsigned int")]
        public uint base_mods;

        [NativeTypeName("unsigned int")]
        public uint latched_mods;

        [NativeTypeName("unsigned int")]
        public uint locked_mods;

        public int compat_state;

        [NativeTypeName("unsigned char")]
        public byte grab_mods;

        [NativeTypeName("unsigned char")]
        public byte compat_grab_mods;

        [NativeTypeName("unsigned char")]
        public byte lookup_mods;

        [NativeTypeName("unsigned char")]
        public byte compat_lookup_mods;

        public int ptr_buttons;

        [NativeTypeName("KeyCode")]
        public byte keycode;

        [NativeTypeName("char")]
        public sbyte event_type;

        [NativeTypeName("char")]
        public sbyte req_major;

        [NativeTypeName("char")]
        public sbyte req_minor;
    }
}
