namespace Silk.NET.X11
{
    public unsafe partial struct XKeyboardState
    {
        public int key_click_percent;

        public int bell_percent;

        [NativeTypeName("unsigned int")]
        public uint bell_pitch;

        [NativeTypeName("unsigned int")]
        public uint bell_duration;

        [NativeTypeName("unsigned long")]
        public nuint led_mask;

        public int global_auto_repeat;

        [NativeTypeName("char[32]")]
        public fixed sbyte auto_repeats[32];
    }
}
