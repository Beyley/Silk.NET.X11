namespace Silk.NET.X11
{
    public partial struct XWindowChanges
    {
        public int x;

        public int y;

        public int width;

        public int height;

        public int border_width;

        [NativeTypeName("Window")]
        public nuint sibling;

        public int stack_mode;
    }
}
