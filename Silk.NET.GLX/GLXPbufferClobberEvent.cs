using System;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    public unsafe partial struct GLXPbufferClobberEvent
    {
        public int event_type;

        public int draw_type;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public Display* display;

        [NativeTypeName("GLXDrawable")]
        public UIntPtr drawable;

        [NativeTypeName("unsigned int")]
        public uint buffer_mask;

        [NativeTypeName("unsigned int")]
        public uint aux_buffer;

        public int x;

        public int y;

        public int width;

        public int height;

        public int count;
    }
}
