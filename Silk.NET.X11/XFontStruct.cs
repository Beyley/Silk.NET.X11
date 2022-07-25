namespace Silk.NET.X11
{
    public unsafe partial struct XFontStruct
    {
        [NativeTypeName("XExtData *")]
        public _XExtData* ext_data;

        [NativeTypeName("Font")]
        public nuint fid;

        [NativeTypeName("unsigned int")]
        public uint direction;

        [NativeTypeName("unsigned int")]
        public uint min_char_or_byte2;

        [NativeTypeName("unsigned int")]
        public uint max_char_or_byte2;

        [NativeTypeName("unsigned int")]
        public uint min_byte1;

        [NativeTypeName("unsigned int")]
        public uint max_byte1;

        public int all_chars_exist;

        [NativeTypeName("unsigned int")]
        public uint default_char;

        public int n_properties;

        public XFontProp* properties;

        public XCharStruct min_bounds;

        public XCharStruct max_bounds;

        public XCharStruct* per_char;

        public int ascent;

        public int descent;
    }
}
