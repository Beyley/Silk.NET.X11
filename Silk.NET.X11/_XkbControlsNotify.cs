namespace Silk.NET.X11
{
    public unsafe partial struct _XkbControlsNotify
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
        public uint changed_ctrls;

        [NativeTypeName("unsigned int")]
        public uint enabled_ctrls;

        [NativeTypeName("unsigned int")]
        public uint enabled_ctrl_changes;

        public int num_groups;

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
