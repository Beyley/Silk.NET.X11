namespace Silk.NET.X11
{
    public unsafe partial struct XSelectionEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint requestor;

        [NativeTypeName("Atom")]
        public nuint selection;

        [NativeTypeName("Atom")]
        public nuint target;

        [NativeTypeName("Atom")]
        public nuint property;

        [NativeTypeName("Time")]
        public nuint time;
    }
}
