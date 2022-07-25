namespace Silk.NET.X11
{
    public unsafe partial struct XTextItem16
    {
        public XChar2b* chars;

        public int nchars;

        public int delta;

        [NativeTypeName("Font")]
        public nuint font;
    }
}
