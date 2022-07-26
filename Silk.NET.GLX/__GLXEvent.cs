using System;
using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct __GLXEvent
    {
        [FieldOffset(0)]
        public GLXPbufferClobberEvent glxpbufferclobber;

        [FieldOffset(0)]
        public GLXBufferSwapComplete glxbufferswapcomplete;

        [FieldOffset(0)]
        [NativeTypeName("long[24]")]
        public _pad_e__FixedBuffer pad;

        public partial struct _pad_e__FixedBuffer
        {
            public IntPtr e0;
            public IntPtr e1;
            public IntPtr e2;
            public IntPtr e3;
            public IntPtr e4;
            public IntPtr e5;
            public IntPtr e6;
            public IntPtr e7;
            public IntPtr e8;
            public IntPtr e9;
            public IntPtr e10;
            public IntPtr e11;
            public IntPtr e12;
            public IntPtr e13;
            public IntPtr e14;
            public IntPtr e15;
            public IntPtr e16;
            public IntPtr e17;
            public IntPtr e18;
            public IntPtr e19;
            public IntPtr e20;
            public IntPtr e21;
            public IntPtr e22;
            public IntPtr e23;

            public unsafe ref IntPtr this[int index]
            {
                get
                {
                    fixed (IntPtr* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }
}
