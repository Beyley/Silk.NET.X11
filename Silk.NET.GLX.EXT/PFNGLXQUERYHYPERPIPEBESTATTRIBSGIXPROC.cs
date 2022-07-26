using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int PFNGLXQUERYHYPERPIPEBESTATTRIBSGIXPROC([NativeTypeName("Display *")] Display* dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList);
}
