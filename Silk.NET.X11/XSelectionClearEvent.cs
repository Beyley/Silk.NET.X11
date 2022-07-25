namespace Silk.NET.X11
{
    public unsafe partial struct XSelectionClearEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("Atom")]
        public nuint selection;

        [NativeTypeName("Time")]
        public nuint time;
    }
}
