namespace Silk.NET.X11
{
    public partial struct XCharStruct
    {
        public short lbearing;

        public short rbearing;

        public short width;

        public short ascent;

        public short descent;

        [NativeTypeName("unsigned short")]
        public ushort attributes;
    }
}
