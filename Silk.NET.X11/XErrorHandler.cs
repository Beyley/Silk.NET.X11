using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int XErrorHandler([NativeTypeName("Display *")] _XDisplay* param0, XErrorEvent* param1);
}
