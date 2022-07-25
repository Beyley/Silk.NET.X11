using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct XEDataObject
    {
        [FieldOffset(0)]
        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [FieldOffset(0)]
        [NativeTypeName("GC")]
        public _XGC* gc;

        [FieldOffset(0)]
        public Visual* visual;

        [FieldOffset(0)]
        public Screen* screen;

        [FieldOffset(0)]
        public ScreenFormat* pixmap_format;

        [FieldOffset(0)]
        public XFontStruct* font;
    }
}
