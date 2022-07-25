using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int XIOErrorHandler([NativeTypeName("Display *")] _XDisplay* param0);
}
