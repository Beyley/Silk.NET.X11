namespace Silk.NET.X11
{
    public unsafe partial struct _XcmsPerScrnInfo
    {
        public XcmsColor screenWhitePt;

        [NativeTypeName("XPointer")]
        public sbyte* functionSet;

        [NativeTypeName("XPointer")]
        public sbyte* screenData;

        [NativeTypeName("unsigned char")]
        public byte state;

        [NativeTypeName("char[3]")]
        public fixed sbyte pad[3];
    }
}
