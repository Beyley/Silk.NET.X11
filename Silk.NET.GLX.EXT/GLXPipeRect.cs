namespace Silk.NET.GLX
{
    public unsafe partial struct GLXPipeRect
    {
        [NativeTypeName("char[80]")]
        public fixed sbyte pipeName[80];

        public int srcXOrigin;

        public int srcYOrigin;

        public int srcWidth;

        public int srcHeight;

        public int destXOrigin;

        public int destYOrigin;

        public int destWidth;

        public int destHeight;
    }
}
