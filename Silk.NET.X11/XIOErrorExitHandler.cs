using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void XIOErrorExitHandler([NativeTypeName("Display *")] _XDisplay* param0, void* param1);
}
