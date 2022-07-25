namespace Silk.NET.X11
{
    public partial struct XRectangle
    {
        public short x;

        public short y;

        [NativeTypeName("unsigned short")]
        public ushort width;

        [NativeTypeName("unsigned short")]
        public ushort height;
    }
}
