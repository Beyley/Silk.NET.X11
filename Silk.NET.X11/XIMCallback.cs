namespace Silk.NET.X11
{
    public unsafe partial struct XIMCallback
    {
        [NativeTypeName("XPointer")]
        public sbyte* client_data;

        [NativeTypeName("XIMProc")]
        public delegate* unmanaged[Cdecl]<_XIM*, sbyte*, sbyte*, void> callback;
    }
}
