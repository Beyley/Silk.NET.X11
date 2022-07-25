namespace Silk.NET.X11
{
    public partial struct XSizeHints
    {
        [NativeTypeName("long")]
        public nint flags;

        public int x;

        public int y;

        public int width;

        public int height;

        public int min_width;

        public int min_height;

        public int max_width;

        public int max_height;

        public int width_inc;

        public int height_inc;

        [NativeTypeName("struct (anonymous struct at Xutil.h:88:2)")]
        public _min_aspect_e__Struct min_aspect;

        [NativeTypeName("struct (anonymous struct at Xutil.h:88:2)")]
        public _min_aspect_e__Struct max_aspect;

        public int base_width;

        public int base_height;

        public int win_gravity;

        public partial struct _min_aspect_e__Struct
        {
            public int x;

            public int y;
        }
    }
}
