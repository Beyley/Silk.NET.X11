using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    [return: NativeTypeName("Atom")]
    public unsafe delegate UIntPtr XkbInternAtomFunc([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);
}
