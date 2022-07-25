namespace Silk.NET.X11
{
    public unsafe partial struct XTextItem
    {
        [NativeTypeName("char *")]
        public sbyte* chars;

        public int nchars;

        public int delta;

        [NativeTypeName("Font")]
        public nuint font;
    }
}
