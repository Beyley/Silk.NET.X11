namespace Silk.NET.X11
{
    public unsafe partial struct XICCallback
    {
        [NativeTypeName("XPointer")]
        public sbyte* client_data;

        [NativeTypeName("XICProc")]
        public delegate* unmanaged[Cdecl]<_XIC*, sbyte*, sbyte*, int> callback;
    }
}
