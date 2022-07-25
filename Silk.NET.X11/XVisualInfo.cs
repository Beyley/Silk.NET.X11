namespace Silk.NET.X11
{
    public unsafe partial struct XVisualInfo
    {
        public Visual* visual;

        [NativeTypeName("VisualID")]
        public nuint visualid;

        public int screen;

        public int depth;

        public int @class;

        [NativeTypeName("unsigned long")]
        public nuint red_mask;

        [NativeTypeName("unsigned long")]
        public nuint green_mask;

        [NativeTypeName("unsigned long")]
        public nuint blue_mask;

        public int colormap_size;

        public int bits_per_rgb;
    }
}
