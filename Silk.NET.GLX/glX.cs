using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX
{
    public static unsafe partial class glX
    {
        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XVisualInfo* glXChooseVisual([NativeTypeName("Display *")] Display* dpy, int screen, int* attribList);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXContext")]
        public static extern __GLXcontextRec* glXCreateContext([NativeTypeName("Display *")] Display* dpy, XVisualInfo* vis, [NativeTypeName("GLXContext")] __GLXcontextRec* shareList, int direct);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXDestroyContext([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* ctx);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXMakeCurrent([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("GLXContext")] __GLXcontextRec* ctx);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXCopyContext([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* src, [NativeTypeName("GLXContext")] __GLXcontextRec* dst, [NativeTypeName("unsigned long")] UIntPtr mask);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXSwapBuffers([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXPixmap")]
        public static extern UIntPtr glXCreateGLXPixmap([NativeTypeName("Display *")] Display* dpy, XVisualInfo* visual, [NativeTypeName("Pixmap")] UIntPtr pixmap);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXDestroyGLXPixmap([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPixmap")] UIntPtr pixmap);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXQueryExtension([NativeTypeName("Display *")] Display* dpy, int* errorb, int* @event);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXQueryVersion([NativeTypeName("Display *")] Display* dpy, int* maj, int* min);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXIsDirect([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* ctx);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXGetConfig([NativeTypeName("Display *")] Display* dpy, XVisualInfo* visual, int attrib, int* value);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXContext")]
        public static extern __GLXcontextRec* glXGetCurrentContext();

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXDrawable")]
        public static extern UIntPtr glXGetCurrentDrawable();

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXWaitGL();

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXWaitX();

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXUseXFont([NativeTypeName("Font")] UIntPtr font, int first, int count, int list);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* glXQueryExtensionsString([NativeTypeName("Display *")] Display* dpy, int screen);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* glXQueryServerString([NativeTypeName("Display *")] Display* dpy, int screen, int name);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* glXGetClientString([NativeTypeName("Display *")] Display* dpy, int name);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern Display* glXGetCurrentDisplay();

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXFBConfig *")]
        public static extern __GLXFBConfigRec** glXChooseFBConfig([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("const int *")] int* attribList, int* nitems);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXGetFBConfigAttrib([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, int attribute, int* value);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXFBConfig *")]
        public static extern __GLXFBConfigRec** glXGetFBConfigs([NativeTypeName("Display *")] Display* dpy, int screen, int* nelements);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XVisualInfo* glXGetVisualFromFBConfig([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXWindow")]
        public static extern UIntPtr glXCreateWindow([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, [NativeTypeName("Window")] UIntPtr win, [NativeTypeName("const int *")] int* attribList);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXDestroyWindow([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXWindow")] UIntPtr window);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXPixmap")]
        public static extern UIntPtr glXCreatePixmap([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, [NativeTypeName("Pixmap")] UIntPtr pixmap, [NativeTypeName("const int *")] int* attribList);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXDestroyPixmap([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPixmap")] UIntPtr pixmap);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXPbuffer")]
        public static extern UIntPtr glXCreatePbuffer([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, [NativeTypeName("const int *")] int* attribList);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXDestroyPbuffer([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbuffer")] UIntPtr pbuf);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXQueryDrawable([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr draw, int attribute, [NativeTypeName("unsigned int *")] uint* value);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXContext")]
        public static extern __GLXcontextRec* glXCreateNewContext([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, int renderType, [NativeTypeName("GLXContext")] __GLXcontextRec* shareList, int direct);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXMakeContextCurrent([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr draw, [NativeTypeName("GLXDrawable")] UIntPtr read, [NativeTypeName("GLXContext")] __GLXcontextRec* ctx);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GLXDrawable")]
        public static extern UIntPtr glXGetCurrentReadDrawable();

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXQueryContext([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* ctx, int attribute, int* value);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXSelectEvent([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("unsigned long")] UIntPtr mask);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXGetSelectedEvent([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("unsigned long *")] UIntPtr* mask);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("__GLXextFuncPtr")]
        public static extern IntPtr glXGetProcAddressARB([NativeTypeName("const GLubyte *")] byte* param0);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("void (*)(void)")]
        public static extern IntPtr glXGetProcAddress([NativeTypeName("const GLubyte *")] byte* procname);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* glXAllocateMemoryNV([NativeTypeName("GLsizei")] int size, [NativeTypeName("GLfloat")] float readfreq, [NativeTypeName("GLfloat")] float writefreq, [NativeTypeName("GLfloat")] float priority);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glXFreeMemoryNV([NativeTypeName("GLvoid *")] void* pointer);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXBindTexImageARB([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbuffer")] UIntPtr pbuffer, int buffer);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXReleaseTexImageARB([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbuffer")] UIntPtr pbuffer, int buffer);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXDrawableAttribARB([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr draw, [NativeTypeName("const int *")] int* attribList);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXGetFrameUsageMESA([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, float* usage);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXBeginFrameTrackingMESA([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXEndFrameTrackingMESA([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable);

        [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int glXQueryFrameTrackingMESA([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("int64_t *")] IntPtr* swapCount, [NativeTypeName("int64_t *")] IntPtr* missedFrames, float* lastMissedUsage);
    }
}
