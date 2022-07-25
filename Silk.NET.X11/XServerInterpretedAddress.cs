namespace Silk.NET.X11
{
    public unsafe partial struct XServerInterpretedAddress
    {
        public int typelength;

        public int valuelength;

        [NativeTypeName("char *")]
        public sbyte* type;

        [NativeTypeName("char *")]
        public sbyte* value;
    }
}
