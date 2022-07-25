namespace Silk.NET.X11
{
    [NativeTypeName("unsigned int")]
    public enum XIMCaretDirection : uint
    {
        XIMForwardChar,
        XIMBackwardChar,
        XIMForwardWord,
        XIMBackwardWord,
        XIMCaretUp,
        XIMCaretDown,
        XIMNextLine,
        XIMPreviousLine,
        XIMLineStart,
        XIMLineEnd,
        XIMAbsolutePosition,
        XIMDontChange,
    }
}
