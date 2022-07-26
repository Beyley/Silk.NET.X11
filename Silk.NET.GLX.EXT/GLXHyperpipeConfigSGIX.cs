namespace Silk.NET.GLX
{
    public unsafe partial struct GLXHyperpipeConfigSGIX
    {
        [NativeTypeName("char[80]")]
        public fixed sbyte pipeName[80];

        public int channel;

        [NativeTypeName("unsigned int")]
        public uint participationType;

        public int timeSlice;
    }
}
