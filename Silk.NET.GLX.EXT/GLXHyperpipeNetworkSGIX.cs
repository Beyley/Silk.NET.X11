namespace Silk.NET.GLX
{
    public unsafe partial struct GLXHyperpipeNetworkSGIX
    {
        [NativeTypeName("char[80]")]
        public fixed sbyte pipeName[80];

        public int networkId;
    }
}
