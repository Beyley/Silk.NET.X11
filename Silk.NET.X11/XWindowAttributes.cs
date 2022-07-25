namespace Silk.NET.X11
{
    public unsafe partial struct XWindowAttributes
    {
        public int x;

        public int y;

        public int width;

        public int height;

        public int border_width;

        public int depth;

        public Visual* visual;

        [NativeTypeName("Window")]
        public nuint root;

        public int @class;

        public int bit_gravity;

        public int win_gravity;

        public int backing_store;

        [NativeTypeName("unsigned long")]
        public nuint backing_planes;

        [NativeTypeName("unsigned long")]
        public nuint backing_pixel;

        public int save_under;

        [NativeTypeName("Colormap")]
        public nuint colormap;

        public int map_installed;

        public int map_state;

        [NativeTypeName("long")]
        public nint all_event_masks;

        [NativeTypeName("long")]
        public nint your_event_mask;

        [NativeTypeName("long")]
        public nint do_not_propagate_mask;

        public int override_redirect;

        public Screen* screen;
    }
}
