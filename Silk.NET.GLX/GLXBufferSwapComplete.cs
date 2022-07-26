using System;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    public unsafe partial struct GLXBufferSwapComplete
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public Display* display;

        [NativeTypeName("GLXDrawable")]
        public UIntPtr drawable;

        public int event_type;

        [NativeTypeName("int64_t")]
        public IntPtr ust;

        [NativeTypeName("int64_t")]
        public IntPtr msc;

        [NativeTypeName("int64_t")]
        public IntPtr sbc;
    }
}
