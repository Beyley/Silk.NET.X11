namespace Silk.NET.X11
{
    public partial struct XStandardColormap
    {
        [NativeTypeName("Colormap")]
        public nuint colormap;

        [NativeTypeName("unsigned long")]
        public nuint red_max;

        [NativeTypeName("unsigned long")]
        public nuint red_mult;

        [NativeTypeName("unsigned long")]
        public nuint green_max;

        [NativeTypeName("unsigned long")]
        public nuint green_mult;

        [NativeTypeName("unsigned long")]
        public nuint blue_max;

        [NativeTypeName("unsigned long")]
        public nuint blue_mult;

        [NativeTypeName("unsigned long")]
        public nuint base_pixel;

        [NativeTypeName("VisualID")]
        public nuint visualid;

        [NativeTypeName("XID")]
        public nuint killid;
    }
}
