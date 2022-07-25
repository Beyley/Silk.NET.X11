namespace Silk.NET.X11
{
    public unsafe partial struct _XkbExtensionDeviceNotify
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
        public uint reason;

        [NativeTypeName("unsigned int")]
        public uint supported;

        [NativeTypeName("unsigned int")]
        public uint unsupported;

        public int first_btn;

        public int num_btns;

        [NativeTypeName("unsigned int")]
        public uint leds_defined;

        [NativeTypeName("unsigned int")]
        public uint led_state;

        public int led_class;

        public int led_id;
    }
}
