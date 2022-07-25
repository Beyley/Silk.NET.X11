namespace Silk.NET.X11
{
    public unsafe partial struct XmbTextItem
    {
        [NativeTypeName("char *")]
        public sbyte* chars;

        public int nchars;

        public int delta;

        [NativeTypeName("XFontSet")]
        public _XOC* font_set;
    }
}
