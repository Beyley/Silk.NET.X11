namespace Silk.NET.X11
{
    public unsafe partial struct XTextProperty
    {
        [NativeTypeName("unsigned char *")]
        public byte* value;

        [NativeTypeName("Atom")]
        public nuint encoding;

        public int format;

        [NativeTypeName("unsigned long")]
        public nuint nitems;
    }
}
