namespace Silk.NET.X11
{
    public unsafe partial struct _XComposeStatus
    {
        [NativeTypeName("XPointer")]
        public sbyte* compose_ptr;

        public int chars_matched;
    }
}
