namespace Silk.NET.X11
{
    public unsafe partial struct _XIMPreeditDrawCallbackStruct
    {
        public int caret;

        public int chg_first;

        public int chg_length;

        [NativeTypeName("XIMText *")]
        public _XIMText* text;
    }
}
