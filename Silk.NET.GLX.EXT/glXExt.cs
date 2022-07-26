using System;
using System.Runtime.InteropServices;
using TerraFX.Interop.Xlib;

namespace Silk.NET.GLX.EXT;

public static unsafe partial class glXExt
{
    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXContext")]
    public static extern __GLXcontextRec* glXCreateContextAttribsARB([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfig")] __GLXFBConfigRec* config, [NativeTypeName("GLXContext")] __GLXcontextRec* share_context, int direct, [NativeTypeName("const int *")] int* attrib_list);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint glXGetGPUIDsAMD([NativeTypeName("unsigned int")] uint maxCount, [NativeTypeName("unsigned int *")] uint* ids);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXGetGPUInfoAMD([NativeTypeName("unsigned int")] uint id, int property, [NativeTypeName("GLenum")] uint dataType, [NativeTypeName("unsigned int")] uint size, void* data);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint glXGetContextGPUIDAMD([NativeTypeName("GLXContext")] __GLXcontextRec* ctx);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXContext")]
    public static extern __GLXcontextRec* glXCreateAssociatedContextAMD([NativeTypeName("unsigned int")] uint id, [NativeTypeName("GLXContext")] __GLXcontextRec* share_list);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXContext")]
    public static extern __GLXcontextRec* glXCreateAssociatedContextAttribsAMD([NativeTypeName("unsigned int")] uint id, [NativeTypeName("GLXContext")] __GLXcontextRec* share_context, [NativeTypeName("const int *")] int* attribList);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXDeleteAssociatedContextAMD([NativeTypeName("GLXContext")] __GLXcontextRec* ctx);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXMakeAssociatedContextCurrentAMD([NativeTypeName("GLXContext")] __GLXcontextRec* ctx);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXContext")]
    public static extern __GLXcontextRec* glXGetCurrentAssociatedContextAMD();

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXBlitContextFramebufferAMD([NativeTypeName("GLXContext")] __GLXcontextRec* dstCtx, [NativeTypeName("GLint")] int srcX0, [NativeTypeName("GLint")] int srcY0, [NativeTypeName("GLint")] int srcX1, [NativeTypeName("GLint")] int srcY1, [NativeTypeName("GLint")] int dstX0, [NativeTypeName("GLint")] int dstY0, [NativeTypeName("GLint")] int dstX1, [NativeTypeName("GLint")] int dstY1, [NativeTypeName("GLbitfield")] uint mask, [NativeTypeName("GLenum")] uint filter);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("Display *")]
    public static extern Display* glXGetCurrentDisplayEXT();

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryContextInfoEXT([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* context, int attribute, int* value);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXContextID")]
    public static extern UIntPtr glXGetContextIDEXT([NativeTypeName("const GLXContext")] __GLXcontextRec* context);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXContext")]
    public static extern __GLXcontextRec* glXImportContextEXT([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContextID")] UIntPtr contextID);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXFreeContextEXT([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* context);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXSwapIntervalEXT([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, int interval);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int")]
    public static extern uint glXGetAGPOffsetMESA([NativeTypeName("const void *")] void* pointer);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXCopySubBufferMESA([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, int x, int y, int width, int height);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXPixmap")]
    public static extern UIntPtr glXCreateGLXPixmapMESA([NativeTypeName("Display *")] Display* dpy, XVisualInfo* visual, [NativeTypeName("Pixmap")] UIntPtr pixmap, [NativeTypeName("Colormap")] UIntPtr cmap);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryCurrentRendererIntegerMESA(int attribute, [NativeTypeName("unsigned int *")] uint* value);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glXQueryCurrentRendererStringMESA(int attribute);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryRendererIntegerMESA([NativeTypeName("Display *")] Display* dpy, int screen, int renderer, int attribute, [NativeTypeName("unsigned int *")] uint* value);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("const char *")]
    public static extern sbyte* glXQueryRendererStringMESA([NativeTypeName("Display *")] Display* dpy, int screen, int renderer, int attribute);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXReleaseBuffersMESA([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLboolean")]
    public static extern byte glXSet3DfxModeMESA([NativeTypeName("GLint")] int mode);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXCopyBufferSubDataNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* readCtx, [NativeTypeName("GLXContext")] __GLXcontextRec* writeCtx, [NativeTypeName("GLenum")] uint readTarget, [NativeTypeName("GLenum")] uint writeTarget, [NativeTypeName("GLintptr")] IntPtr readOffset, [NativeTypeName("GLintptr")] IntPtr writeOffset, [NativeTypeName("GLsizeiptr")] IntPtr size);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXNamedCopyBufferSubDataNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* readCtx, [NativeTypeName("GLXContext")] __GLXcontextRec* writeCtx, [NativeTypeName("GLuint")] uint readBuffer, [NativeTypeName("GLuint")] uint writeBuffer, [NativeTypeName("GLintptr")] IntPtr readOffset, [NativeTypeName("GLintptr")] IntPtr writeOffset, [NativeTypeName("GLsizeiptr")] IntPtr size);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXCopyImageSubDataNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXContext")] __GLXcontextRec* srcCtx, [NativeTypeName("GLuint")] uint srcName, [NativeTypeName("GLenum")] uint srcTarget, [NativeTypeName("GLint")] int srcLevel, [NativeTypeName("GLint")] int srcX, [NativeTypeName("GLint")] int srcY, [NativeTypeName("GLint")] int srcZ, [NativeTypeName("GLXContext")] __GLXcontextRec* dstCtx, [NativeTypeName("GLuint")] uint dstName, [NativeTypeName("GLenum")] uint dstTarget, [NativeTypeName("GLint")] int dstLevel, [NativeTypeName("GLint")] int dstX, [NativeTypeName("GLint")] int dstY, [NativeTypeName("GLint")] int dstZ, [NativeTypeName("GLsizei")] int width, [NativeTypeName("GLsizei")] int height, [NativeTypeName("GLsizei")] int depth);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXDelayBeforeSwapNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("GLfloat")] float seconds);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("unsigned int *")]
    public static extern uint* glXEnumerateVideoDevicesNV([NativeTypeName("Display *")] Display* dpy, int screen, int* nelements);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXBindVideoDeviceNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("unsigned int")] uint video_slot, [NativeTypeName("unsigned int")] uint video_device, [NativeTypeName("const int *")] int* attrib_list);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXJoinSwapGroupNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("GLuint")] uint group);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXBindSwapBarrierNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLuint")] uint group, [NativeTypeName("GLuint")] uint barrier);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQuerySwapGroupNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("GLuint *")] uint* group, [NativeTypeName("GLuint *")] uint* barrier);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryMaxSwapGroupsNV([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("GLuint *")] uint* maxGroups, [NativeTypeName("GLuint *")] uint* maxBarriers);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryFrameCountNV([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("GLuint *")] uint* count);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXResetFrameCountNV([NativeTypeName("Display *")] Display* dpy, int screen);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXBindVideoCaptureDeviceNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("unsigned int")] uint video_capture_slot, [NativeTypeName("GLXVideoCaptureDeviceNV")] UIntPtr device);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXVideoCaptureDeviceNV *")]
    public static extern UIntPtr* glXEnumerateVideoCaptureDevicesNV([NativeTypeName("Display *")] Display* dpy, int screen, int* nelements);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXLockVideoCaptureDeviceNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXVideoCaptureDeviceNV")] UIntPtr device);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryVideoCaptureDeviceNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXVideoCaptureDeviceNV")] UIntPtr device, int attribute, int* value);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXReleaseVideoCaptureDeviceNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXVideoCaptureDeviceNV")] UIntPtr device);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXGetVideoDeviceNV([NativeTypeName("Display *")] Display* dpy, int screen, int numVideoDevices, [NativeTypeName("GLXVideoDeviceNV *")] uint* pVideoDevice);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXReleaseVideoDeviceNV([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("GLXVideoDeviceNV")] uint VideoDevice);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXBindVideoImageNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXVideoDeviceNV")] uint VideoDevice, [NativeTypeName("GLXPbuffer")] UIntPtr pbuf, int iVideoBuffer);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXReleaseVideoImageNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbuffer")] UIntPtr pbuf);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXSendPbufferToVideoNV([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbuffer")] UIntPtr pbuf, int iBufferType, [NativeTypeName("unsigned long *")] UIntPtr* pulCounterPbuffer, [NativeTypeName("GLboolean")] byte bBlock);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXGetVideoInfoNV([NativeTypeName("Display *")] Display* dpy, int screen, [NativeTypeName("GLXVideoDeviceNV")] uint VideoDevice, [NativeTypeName("unsigned long *")] UIntPtr* pulCounterOutputPbuffer, [NativeTypeName("unsigned long *")] UIntPtr* pulCounterOutputVideo);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXGetSyncValuesOML([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("int64_t *")] IntPtr* ust, [NativeTypeName("int64_t *")] IntPtr* msc, [NativeTypeName("int64_t *")] IntPtr* sbc);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXGetMscRateOML([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("int32_t *")] int* numerator, [NativeTypeName("int32_t *")] int* denominator);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("int64_t")]
    public static extern IntPtr glXSwapBuffersMscOML([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("int64_t")] IntPtr target_msc, [NativeTypeName("int64_t")] IntPtr divisor, [NativeTypeName("int64_t")] IntPtr remainder);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXWaitForMscOML([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("int64_t")] IntPtr target_msc, [NativeTypeName("int64_t")] IntPtr divisor, [NativeTypeName("int64_t")] IntPtr remainder, [NativeTypeName("int64_t *")] IntPtr* ust, [NativeTypeName("int64_t *")] IntPtr* msc, [NativeTypeName("int64_t *")] IntPtr* sbc);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXWaitForSbcOML([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("int64_t")] IntPtr target_sbc, [NativeTypeName("int64_t *")] IntPtr* ust, [NativeTypeName("int64_t *")] IntPtr* msc, [NativeTypeName("int64_t *")] IntPtr* sbc);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXGetFBConfigAttribSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config, int attribute, int* value);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXFBConfigSGIX *")]
    public static extern __GLXFBConfigRec** glXChooseFBConfigSGIX([NativeTypeName("Display *")] Display* dpy, int screen, int* attrib_list, int* nelements);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXPixmap")]
    public static extern UIntPtr glXCreateGLXPixmapWithConfigSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config, [NativeTypeName("Pixmap")] UIntPtr pixmap);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXContext")]
    public static extern __GLXcontextRec* glXCreateContextWithConfigSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config, int render_type, [NativeTypeName("GLXContext")] __GLXcontextRec* share_list, int direct);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern XVisualInfo* glXGetVisualFromFBConfigSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXFBConfigSGIX")]
    public static extern __GLXFBConfigRec* glXGetFBConfigFromVisualSGIX([NativeTypeName("Display *")] Display* dpy, XVisualInfo* vis);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern GLXHyperpipeNetworkSGIX* glXQueryHyperpipeNetworkSGIX([NativeTypeName("Display *")] Display* dpy, int* npipes);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXHyperpipeConfigSGIX([NativeTypeName("Display *")] Display* dpy, int networkId, int npipes, GLXHyperpipeConfigSGIX* cfg, int* hpId);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern GLXHyperpipeConfigSGIX* glXQueryHyperpipeConfigSGIX([NativeTypeName("Display *")] Display* dpy, int hpId, int* npipes);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXDestroyHyperpipeConfigSGIX([NativeTypeName("Display *")] Display* dpy, int hpId);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXBindHyperpipeSGIX([NativeTypeName("Display *")] Display* dpy, int hpId);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryHyperpipeBestAttribSGIX([NativeTypeName("Display *")] Display* dpy, int timeSlice, int attrib, int size, void* attribList, void* returnAttribList);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXHyperpipeAttribSGIX([NativeTypeName("Display *")] Display* dpy, int timeSlice, int attrib, int size, void* attribList);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryHyperpipeAttribSGIX([NativeTypeName("Display *")] Display* dpy, int timeSlice, int attrib, int size, void* returnAttribList);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXPbufferSGIX")]
    public static extern UIntPtr glXCreateGLXPbufferSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXFBConfigSGIX")] __GLXFBConfigRec* config, [NativeTypeName("unsigned int")] uint width, [NativeTypeName("unsigned int")] uint height, int* attrib_list);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXDestroyGLXPbufferSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbufferSGIX")] UIntPtr pbuf);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXQueryGLXPbufferSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXPbufferSGIX")] UIntPtr pbuf, int attribute, [NativeTypeName("unsigned int *")] uint* value);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXSelectEventSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("unsigned long")] UIntPtr mask);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXGetSelectedEventSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("unsigned long *")] UIntPtr* mask);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXBindSwapBarrierSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, int barrier);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryMaxSwapBarriersSGIX([NativeTypeName("Display *")] Display* dpy, int screen, int* max);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXJoinSwapGroupSGIX([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr drawable, [NativeTypeName("GLXDrawable")] UIntPtr member);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXBindChannelToWindowSGIX([NativeTypeName("Display *")] Display* display, int screen, int channel, [NativeTypeName("Window")] UIntPtr window);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXChannelRectSGIX([NativeTypeName("Display *")] Display* display, int screen, int channel, int x, int y, int w, int h);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryChannelRectSGIX([NativeTypeName("Display *")] Display* display, int screen, int channel, int* dx, int* dy, int* dw, int* dh);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXQueryChannelDeltasSGIX([NativeTypeName("Display *")] Display* display, int screen, int channel, int* x, int* y, int* w, int* h);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXChannelRectSyncSGIX([NativeTypeName("Display *")] Display* display, int screen, int channel, [NativeTypeName("GLenum")] uint synctype);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern void glXCushionSGI([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("Window")] UIntPtr window, float cushion);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXMakeCurrentReadSGI([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("GLXDrawable")] UIntPtr draw, [NativeTypeName("GLXDrawable")] UIntPtr read, [NativeTypeName("GLXContext")] __GLXcontextRec* ctx);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    [return: NativeTypeName("GLXDrawable")]
    public static extern UIntPtr glXGetCurrentReadDrawableSGI();

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXSwapIntervalSGI(int interval);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXGetVideoSyncSGI([NativeTypeName("unsigned int *")] uint* count);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXWaitVideoSyncSGI(int divisor, int remainder, [NativeTypeName("unsigned int *")] uint* count);

    [DllImport("GLX", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
    public static extern int glXGetTransparentIndexSUN([NativeTypeName("Display *")] Display* dpy, [NativeTypeName("Window")] UIntPtr overlay, [NativeTypeName("Window")] UIntPtr underlay, [NativeTypeName("unsigned long *")] UIntPtr* pTransparentIndex);
}
