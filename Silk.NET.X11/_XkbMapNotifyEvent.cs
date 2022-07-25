namespace Silk.NET.X11
{
    public unsafe partial struct _XkbMapNotifyEvent
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

        [NativeTypeName("unsigned int")]
        public uint flags;

        public int first_type;

        public int num_types;

        [NativeTypeName("KeyCode")]
        public byte min_key_code;

        [NativeTypeName("KeyCode")]
        public byte max_key_code;

        [NativeTypeName("KeyCode")]
        public byte first_key_sym;

        [NativeTypeName("KeyCode")]
        public byte first_key_act;

        [NativeTypeName("KeyCode")]
        public byte first_key_behavior;

        [NativeTypeName("KeyCode")]
        public byte first_key_explicit;

        [NativeTypeName("KeyCode")]
        public byte first_modmap_key;

        [NativeTypeName("KeyCode")]
        public byte first_vmodmap_key;

        public int num_key_syms;

        public int num_key_acts;

        public int num_key_behaviors;

        public int num_key_explicit;

        public int num_modmap_keys;

        public int num_vmodmap_keys;

        [NativeTypeName("unsigned int")]
        public uint vmods;
    }
}
