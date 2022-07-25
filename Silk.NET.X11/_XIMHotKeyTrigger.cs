namespace Silk.NET.X11
{
    public partial struct _XIMHotKeyTrigger
    {
        [NativeTypeName("KeySym")]
        public nuint keysym;

        public int modifier;

        public int modifier_mask;
    }
}
