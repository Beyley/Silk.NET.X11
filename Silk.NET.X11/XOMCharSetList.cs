namespace Silk.NET.X11
{
    public unsafe partial struct XOMCharSetList
    {
        public int charset_count;

        [NativeTypeName("char **")]
        public sbyte** charset_list;
    }
}
