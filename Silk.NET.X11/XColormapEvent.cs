namespace Silk.NET.X11
{
    public unsafe partial struct XColormapEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public nuint serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public _XDisplay* display;

        [NativeTypeName("Window")]
        public nuint window;

        [NativeTypeName("Colormap")]
        public nuint colormap;

        public int @new;

        public int state;
    }
}
