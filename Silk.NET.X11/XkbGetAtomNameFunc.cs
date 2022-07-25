using System;
using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("char *")]
    public unsafe delegate sbyte* XkbGetAtomNameFunc([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Atom")] UIntPtr param1);
}
