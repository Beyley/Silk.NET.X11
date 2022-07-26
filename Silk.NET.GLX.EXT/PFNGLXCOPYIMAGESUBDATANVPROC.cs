using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLXCOPYIMAGESUBDATANVPROC([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* srcCtx, [NativeTypeName("GLuint")] uint srcName, [NativeTypeName("GLenum")] uint srcTarget, [NativeTypeName("GLint")] int srcLevel, [NativeTypeName("GLint")] int srcX, [NativeTypeName("GLint")] int srcY, [NativeTypeName("GLint")] int srcZ, [NativeTypeName("GLXContext")] __GLXcontextRec* dstCtx, [NativeTypeName("GLuint")] uint dstName, [NativeTypeName("GLenum")] uint dstTarget, [NativeTypeName("GLint")] int dstLevel, [NativeTypeName("GLint")] int dstX, [NativeTypeName("GLint")] int dstY, [NativeTypeName("GLint")] int dstZ, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLsizei")] int depth);
}
