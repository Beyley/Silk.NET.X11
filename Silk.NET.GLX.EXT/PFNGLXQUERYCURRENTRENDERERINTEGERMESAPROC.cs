using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYCURRENTRENDERERINTEGERMESAPROC(int attribute, [NativeTypeName("unsigned int *")] uint* value);
}
