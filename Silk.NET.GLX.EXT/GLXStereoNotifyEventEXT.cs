using System;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    public unsafe partial struct GLXStereoNotifyEventEXT
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public Display* display;

        public int extension;

        public int evtype;

        [NativeTypeName("GLXDrawable")]
        public UIntPtr window;

        public int stereo_tree;
    }
}
