namespace Silk.NET.X11
{
    public partial struct XWMHints
    {
        [NativeTypeName("long")]
        public nint flags;

        public int input;

        public int initial_state;

        [NativeTypeName("Pixmap")]
        public nuint icon_pixmap;

        [NativeTypeName("Window")]
        public nuint icon_window;

        public int icon_x;

        public int icon_y;

        [NativeTypeName("Pixmap")]
        public nuint icon_mask;

        [NativeTypeName("XID")]
        public nuint window_group;
    }
}
