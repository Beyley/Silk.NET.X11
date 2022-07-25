namespace Silk.NET.X11
{
    public unsafe partial struct _XkbNamesNotify
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

        public int first_type;

        public int num_types;

        public int first_lvl;

        public int num_lvls;

        public int num_aliases;

        public int num_radio_groups;

        [NativeTypeName("unsigned int")]
        public uint changed_vmods;

        [NativeTypeName("unsigned int")]
        public uint changed_groups;

        [NativeTypeName("unsigned int")]
        public uint changed_indicators;

        public int first_key;

        public int num_keys;
    }
}
