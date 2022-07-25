namespace Silk.NET.X11
{
    public unsafe partial struct XHostAddress
    {
        public int family;

        public int length;

        [NativeTypeName("char *")]
        public sbyte* address;
    }
}
