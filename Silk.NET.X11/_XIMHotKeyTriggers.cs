namespace Silk.NET.X11
{
    public unsafe partial struct _XIMHotKeyTriggers
    {
        public int num_hot_key;

        [NativeTypeName("XIMHotKeyTrigger *")]
        public _XIMHotKeyTrigger* key;
    }
}
