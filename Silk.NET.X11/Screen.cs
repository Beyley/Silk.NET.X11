namespace Silk.NET.X11
{
    public unsafe partial struct Screen
    {
        [NativeTypeName("XExtData *")]
        public _XExtData* ext_data;

        [NativeTypeName("struct _XDisplay *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint root;

        public int width;

        public int height;

        public int mwidth;

        public int mheight;

        public int ndepths;

        public Depth* depths;

        public int root_depth;

        public Visual* root_visual;

        [NativeTypeName("GC")]
        public _XGC* default_gc;

        [NativeTypeName("Colormap")]
        public nuint cmap;

        [NativeTypeName("unsigned long")]
        public nuint white_pixel;

        [NativeTypeName("unsigned long")]
        public nuint black_pixel;

        public int max_maps;

        public int min_maps;

        public int backing_store;

        public int save_unders;

        [NativeTypeName("long")]
        public nint root_input_mask;
    }
}
