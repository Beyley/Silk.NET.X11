namespace Silk.NET.X11
{
    public partial struct XFontProp
    {
        [NativeTypeName("Atom")]
        public nuint name;

        [NativeTypeName("unsigned long")]
        public nuint card32;
    }
}
