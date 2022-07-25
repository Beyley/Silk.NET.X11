namespace Silk.NET.X11
{
    public partial struct XTimeCoord
    {
        [NativeTypeName("Time")]
        public nuint time;

        public short x;

        public short y;
    }
}
