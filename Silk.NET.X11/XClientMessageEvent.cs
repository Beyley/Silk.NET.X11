using System;
using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    public unsafe partial struct XClientMessageEvent
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
        public nuint message_type;

        public int format;

        [NativeTypeName("union (anonymous union at Xlib.h:905:2)")]
        public _data_e__Union data;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _data_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("char[20]")]
            public fixed sbyte b[20];

            [FieldOffset(0)]
            [NativeTypeName("short[10]")]
            public fixed short s[10];

            [FieldOffset(0)]
            [NativeTypeName("long[5]")]
            public _l_e__FixedBuffer l;

            public partial struct _l_e__FixedBuffer
            {
                public nint e0;
                public nint e1;
                public nint e2;
                public nint e3;
                public nint e4;

                public ref nint this[int index]
                {
                    get
                    {
                        return ref AsSpan()[index];
                    }
                }

                public Span<nint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 5);
            }
        }
    }
}
