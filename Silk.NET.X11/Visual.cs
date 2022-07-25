namespace Silk.NET.X11
{
    public unsafe partial struct Visual
    {
        [NativeTypeName("XExtData *")]
        public _XExtData* ext_data;

        [NativeTypeName("VisualID")]
        public nuint visualid;

        public int @class;

        [NativeTypeName("unsigned long")]
        public nuint red_mask;

        [NativeTypeName("unsigned long")]
        public nuint green_mask;

        [NativeTypeName("unsigned long")]
        public nuint blue_mask;

        public int bits_per_rgb;

        public int map_entries;
    }
}
