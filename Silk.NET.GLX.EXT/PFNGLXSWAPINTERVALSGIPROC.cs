using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate int PFNGLXSWAPINTERVALSGIPROC(int interval);
}