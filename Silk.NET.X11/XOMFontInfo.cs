namespace Silk.NET.X11
{
    public unsafe partial struct XOMFontInfo
    {
        public int num_font;

        public XFontStruct** font_struct_list;

        [NativeTypeName("char **")]
        public sbyte** font_name_list;
    }
}
