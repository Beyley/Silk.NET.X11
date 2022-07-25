namespace Silk.NET.X11
{
    public unsafe partial struct XwcTextItem
    {
        [NativeTypeName("wchar_t *")]
        public int* chars;

        public int nchars;

        public int delta;

        [NativeTypeName("XFontSet")]
        public _XOC* font_set;
    }
}
