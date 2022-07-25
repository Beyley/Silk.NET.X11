namespace Silk.NET.X11
{
    public unsafe partial struct XIMStyles
    {
        [NativeTypeName("unsigned short")]
        public ushort count_styles;

        [NativeTypeName("XIMStyle *")]
        public nuint* supported_styles;
    }
}
