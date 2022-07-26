using System.Runtime.InteropServices;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXBLITCONTEXTFRAMEBUFFERAMDPROC([NativeTypeName("GLXContext")] __GLXcontextRec* dstCtx, [NativeTypeName("GLint")] int srcX0, [NativeTypeName("GLint")] int srcY0, [NativeTypeName("GLint")] int srcX1, [NativeTypeName("GLint")] int srcY1, [NativeTypeName("GLint")] int dstX0, [NativeTypeName("GLint")] int dstY0, [NativeTypeName("GLint")] int dstX1, [NativeTypeName("GLint")] int dstY1, [NativeTypeName("GLbitfield")] uint mask, [NativeTypeName("GLenum")] uint filter);
}
