namespace Silk.NET.X11
{
    public unsafe partial struct _XExtData
    {
        public int number;

        [NativeTypeName("struct _XExtData *")]
        public _XExtData* next;

        [NativeTypeName("int (*)(struct _XExtData *)")]
        public delegate* unmanaged[Cdecl]<_XExtData*, int> free_private;

        [NativeTypeName("XPointer")]
        public sbyte* private_data;
    }
}
