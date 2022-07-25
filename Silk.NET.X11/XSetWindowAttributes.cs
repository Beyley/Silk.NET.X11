namespace Silk.NET.X11
{
    public partial struct XSetWindowAttributes
    {
        [NativeTypeName("Pixmap")]
        public nuint background_pixmap;

        [NativeTypeName("unsigned long")]
        public nuint background_pixel;

        [NativeTypeName("Pixmap")]
        public nuint border_pixmap;

        [NativeTypeName("unsigned long")]
        public nuint border_pixel;

        public int bit_gravity;

        public int win_gravity;

        public int backing_store;

        [NativeTypeName("unsigned long")]
        public nuint backing_planes;

        [NativeTypeName("unsigned long")]
        public nuint backing_pixel;

        public int save_under;

        [NativeTypeName("long")]
        public nint event_mask;

        [NativeTypeName("long")]
        public nint do_not_propagate_mask;

        public int override_redirect;

        [NativeTypeName("Colormap")]
        public nuint colormap;

        [NativeTypeName("Cursor")]
        public nuint cursor;
    }
}
