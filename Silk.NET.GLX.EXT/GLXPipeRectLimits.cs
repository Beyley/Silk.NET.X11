namespace Silk.NET.GLX
{
    public unsafe partial struct GLXPipeRectLimits
    {
        [NativeTypeName("char[80]")]
        public fixed sbyte pipeName[80];

        public int XOrigin;

        public int YOrigin;

        public int maxHeight;

        public int maxWidth;
    }
}
