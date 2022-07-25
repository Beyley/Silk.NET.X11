namespace Silk.NET.X11
{
    public unsafe partial struct __AnonymousRecord_Xlib_L493_C9
    {
        [NativeTypeName("XExtData *")]
        public _XExtData* ext_data;

        [NativeTypeName("struct _XPrivate *")]
        public _XPrivate* private1;

        public int fd;

        public int private2;

        public int proto_major_version;

        public int proto_minor_version;

        [NativeTypeName("char *")]
        public sbyte* vendor;

        [NativeTypeName("XID")]
        public nuint private3;

        [NativeTypeName("XID")]
        public nuint private4;

        [NativeTypeName("XID")]
        public nuint private5;

        public int private6;

        [NativeTypeName("XID (*)(struct _XDisplay *)")]
        public delegate* unmanaged[Cdecl]<_XDisplay*, nuint> resource_alloc;

        public int byte_order;

        public int bitmap_unit;

        public int bitmap_pad;

        public int bitmap_bit_order;

        public int nformats;

        public ScreenFormat* pixmap_format;

        public int private8;

        public int release;

        [NativeTypeName("struct _XPrivate *")]
        public _XPrivate* private9;

        [NativeTypeName("struct _XPrivate *")]
        public _XPrivate* private10;

        public int qlen;

        [NativeTypeName("unsigned long")]
        public nuint last_request_read;

        [NativeTypeName("unsigned long")]
        public nuint request;

        [NativeTypeName("XPointer")]
        public sbyte* private11;

        [NativeTypeName("XPointer")]
        public sbyte* private12;

        [NativeTypeName("XPointer")]
        public sbyte* private13;

        [NativeTypeName("XPointer")]
        public sbyte* private14;

        [NativeTypeName("unsigned int")]
        public uint max_request_size;

        [NativeTypeName("struct _XrmHashBucketRec *")]
        public _XrmHashBucketRec* db;

        [NativeTypeName("int (*)(struct _XDisplay *)")]
        public delegate* unmanaged[Cdecl]<_XDisplay*, int> private15;

        [NativeTypeName("char *")]
        public sbyte* display_name;

        public int default_screen;

        public int nscreens;

        public Screen* screens;

        [NativeTypeName("unsigned long")]
        public nuint motion_buffer;

        [NativeTypeName("unsigned long")]
        public nuint private16;

        public int min_keycode;

        public int max_keycode;

        [NativeTypeName("XPointer")]
        public sbyte* private17;

        [NativeTypeName("XPointer")]
        public sbyte* private18;

        public int private19;

        [NativeTypeName("char *")]
        public sbyte* xdefaults;
    }
}
