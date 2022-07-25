namespace Silk.NET.X11
{
    public partial struct XColor
    {
        [NativeTypeName("unsigned long")]
        public nuint pixel;

        [NativeTypeName("unsigned short")]
        public ushort red;

        [NativeTypeName("unsigned short")]
        public ushort green;

        [NativeTypeName("unsigned short")]
        public ushort blue;

        [NativeTypeName("char")]
        public sbyte flags;

        [NativeTypeName("char")]
        public sbyte pad;
    }
}
