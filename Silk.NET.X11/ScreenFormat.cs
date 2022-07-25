namespace Silk.NET.X11
{
    public unsafe partial struct ScreenFormat
    {
        [NativeTypeName("XExtData *")]
        public _XExtData* ext_data;

        public int depth;

        public int bits_per_pixel;

        public int scanline_pad;
    }
}
