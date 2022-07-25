using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    public static unsafe partial class Methods
    {
        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int _Xmblen([NativeTypeName("char *")] sbyte* str, int len);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XFontStruct* XLoadQueryFont([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XFontStruct* XQueryFont([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XID")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XTimeCoord* XGetMotionEvents([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Time")] nuint param2, [NativeTypeName("Time")] nuint param3, int* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XModifierKeymap* XDeleteModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XModifierKeymap* XGetModifierMapping([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XModifierKeymap* XInsertModifiermapEntry(XModifierKeymap* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XModifierKeymap* XNewModifiermap(int param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern _XImage* XCreateImage([NativeTypeName("Display *")] _XDisplay* param0, Visual* param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, [NativeTypeName("char *")] sbyte* param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInitImage([NativeTypeName("XImage *")] _XImage* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern _XImage* XGetImage([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XImage *")]
        public static extern _XImage* XGetSubImage([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned long")] nuint param6, int param7, [NativeTypeName("XImage *")] _XImage* param8, int param9, int param10);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern _XDisplay* XOpenDisplay([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XrmInitialize();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBytes([NativeTypeName("Display *")] _XDisplay* param0, int* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XFetchBuffer([NativeTypeName("Display *")] _XDisplay* param0, int* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetAtomName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Atom")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetAtomNames([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Atom *")] nuint* param1, int param2, [NativeTypeName("char **")] sbyte** param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetDefault([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayName([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XKeysymToString([NativeTypeName("KeySym")] nuint param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern delegate* unmanaged[Cdecl]<_XDisplay*, int> XSynchronize([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int (*)(Display *)")]
        public static extern delegate* unmanaged[Cdecl]<_XDisplay*, int> XSetAfterFunction([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("int (*)(Display *)")] delegate* unmanaged[Cdecl]<_XDisplay*, int> param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Atom")]
        public static extern nuint XInternAtom([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInternAtoms([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("char **")] sbyte** param1, int param2, int param3, [NativeTypeName("Atom *")] nuint* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern nuint XCopyColormapAndFree([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern nuint XCreateColormap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, Visual* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern nuint XCreatePixmapCursor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Pixmap")] nuint param1, [NativeTypeName("Pixmap")] nuint param2, XColor* param3, XColor* param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern nuint XCreateGlyphCursor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Font")] nuint param1, [NativeTypeName("Font")] nuint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("const XColor *")] XColor* param5, [NativeTypeName("const XColor *")] XColor* param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Cursor")]
        public static extern nuint XCreateFontCursor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Font")]
        public static extern nuint XLoadFont([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern _XGC* XCreateGC([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned long")] nuint param2, XGCValues* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GContext")]
        public static extern nuint XGContextFromGC([NativeTypeName("GC")] _XGC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XFlushGC([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern nuint XCreatePixmap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern nuint XCreateBitmapFromData([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Pixmap")]
        public static extern nuint XCreatePixmapFromBitmapData([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long")] nuint param5, [NativeTypeName("unsigned long")] nuint param6, [NativeTypeName("unsigned int")] uint param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XCreateSimpleWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned long")] nuint param7, [NativeTypeName("unsigned long")] nuint param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XGetSelectionOwner([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Atom")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XCreateWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, [NativeTypeName("unsigned int")] uint param8, Visual* param9, [NativeTypeName("unsigned long")] nuint param10, XSetWindowAttributes* param11);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap *")]
        public static extern nuint* XListInstalledColormaps([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFonts([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListFontsWithInfo([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int* param3, XFontStruct** param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XGetFontPath([NativeTypeName("Display *")] _XDisplay* param0, int* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char **")]
        public static extern sbyte** XListExtensions([NativeTypeName("Display *")] _XDisplay* param0, int* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Atom *")]
        public static extern nuint* XListProperties([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XHostAddress* XListHosts([NativeTypeName("Display *")] _XDisplay* param0, int* param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern nuint XKeycodeToKeysym([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeyCode")] byte param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern nuint XLookupKeysym(XKeyEvent* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym *")]
        public static extern nuint* XGetKeyboardMapping([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeyCode")] byte param1, int param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern nuint XStringToKeysym([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint XMaxRequestSize([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint XExtendedMaxRequestSize([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XResourceManagerString([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XScreenResourceString(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XDisplayMotionBufferSize([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("VisualID")]
        public static extern nuint XVisualIDFromVisual(Visual* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInitThreads();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XLockDisplay([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XUnlockDisplay([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XExtCodes* XInitExtension([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XExtCodes* XAddExtension([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XExtData *")]
        public static extern _XExtData* XFindOnExtensionList([NativeTypeName("XExtData **")] _XExtData** param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XExtData **")]
        public static extern _XExtData** XEHeadOfExtensionList(XEDataObject param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XRootWindow([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XDefaultRootWindow([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Window")]
        public static extern nuint XRootWindowOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Visual* XDefaultVisual([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Visual* XDefaultVisualOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern _XGC* XDefaultGC([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("GC")]
        public static extern _XGC* XDefaultGCOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XBlackPixel([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XWhitePixel([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XAllPlanes();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XBlackPixelOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XWhitePixelOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XNextRequest([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned long")]
        public static extern nuint XLastKnownRequestProcessed([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XServerVendor([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XDisplayString([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern nuint XDefaultColormap([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Colormap")]
        public static extern nuint XDefaultColormapOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern _XDisplay* XDisplayOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Screen* XScreenOfDisplay([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Screen* XDefaultScreenOfDisplay([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("long")]
        public static extern nint XEventMaskOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XScreenNumberOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XErrorHandler")]
        public static extern delegate* unmanaged[Cdecl]<_XDisplay*, XErrorEvent*, int> XSetErrorHandler([NativeTypeName("XErrorHandler")] delegate* unmanaged[Cdecl]<_XDisplay*, XErrorEvent*, int> param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XIOErrorHandler")]
        public static extern delegate* unmanaged[Cdecl]<_XDisplay*, int> XSetIOErrorHandler([NativeTypeName("XIOErrorHandler")] delegate* unmanaged[Cdecl]<_XDisplay*, int> param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetIOErrorExitHandler([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XIOErrorExitHandler")] delegate* unmanaged[Cdecl]<_XDisplay*, void*, void> param1, void* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XPixmapFormatValues* XListPixmapFormats([NativeTypeName("Display *")] _XDisplay* param0, int* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* XListDepths([NativeTypeName("Display *")] _XDisplay* param0, int param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XReconfigureWMWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("unsigned int")] uint param3, XWindowChanges* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMProtocols([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom **")] nuint** param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWMProtocols([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom *")] nuint* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XIconifyWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWithdrawWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetCommand([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("char ***")] sbyte*** param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMColormapWindows([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window **")] nuint** param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWMColormapWindows([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window *")] nuint* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XFreeStringList([NativeTypeName("char **")] sbyte** param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetTransientForHint([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XActivateScreenSaver([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddHost([NativeTypeName("Display *")] _XDisplay* param0, XHostAddress* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddHosts([NativeTypeName("Display *")] _XDisplay* param0, XHostAddress* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddToExtensionList([NativeTypeName("struct _XExtData **")] _XExtData** param0, [NativeTypeName("XExtData *")] _XExtData* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddToSaveSet([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllocColor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, XColor* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllocColorCells([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned long *")] nuint* param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllocColorPlanes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, int param2, [NativeTypeName("unsigned long *")] nuint* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned long *")] nuint* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllocNamedColor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3, XColor* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAllowEvents([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("Time")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAutoRepeatOff([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAutoRepeatOn([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XBell([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XBitmapBitOrder([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XBitmapPad([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XBitmapUnit([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCellsOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeActivePointerGrab([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("Cursor")] nuint param2, [NativeTypeName("Time")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeGC([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("unsigned long")] nuint param2, XGCValues* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeKeyboardControl([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned long")] nuint param1, XKeyboardControl* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeKeyboardMapping([NativeTypeName("Display *")] _XDisplay* param0, int param1, int param2, [NativeTypeName("KeySym *")] nuint* param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangePointerControl([NativeTypeName("Display *")] _XDisplay* param0, int param1, int param2, int param3, int param4, int param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeProperty([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom")] nuint param2, [NativeTypeName("Atom")] nuint param3, int param4, int param5, [NativeTypeName("const unsigned char *")] byte* param6, int param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeSaveSet([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XChangeWindowAttributes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned long")] nuint param2, XSetWindowAttributes* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckIfEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XEvent *")] union _XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged[Cdecl]<_XDisplay*, union _XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckMaskEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("long")] nint param1, [NativeTypeName("XEvent *")] union _XEvent* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckTypedEvent([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("XEvent *")] union _XEvent* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckTypedWindowEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("XEvent *")] union _XEvent* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCheckWindowEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("long")] nint param2, [NativeTypeName("XEvent *")] union _XEvent* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCirculateSubwindows([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCirculateSubwindowsDown([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCirculateSubwindowsUp([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XClearArea([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XClearWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCloseDisplay([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XConfigureWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned int")] uint param2, XWindowChanges* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XConnectionNumber([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XConvertSelection([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Atom")] nuint param1, [NativeTypeName("Atom")] nuint param2, [NativeTypeName("Atom")] nuint param3, [NativeTypeName("Window")] nuint param4, [NativeTypeName("Time")] nuint param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCopyArea([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("Drawable")] nuint param2, [NativeTypeName("GC")] _XGC* param3, int param4, int param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCopyGC([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("GC")] _XGC* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCopyPlane([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("Drawable")] nuint param2, [NativeTypeName("GC")] _XGC* param3, int param4, int param5, [NativeTypeName("unsigned int")] uint param6, [NativeTypeName("unsigned int")] uint param7, int param8, int param9, [NativeTypeName("unsigned long")] nuint param10);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDefaultDepth([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDefaultDepthOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDefaultScreen([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDefineCursor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Cursor")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDeleteProperty([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDestroyWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDestroySubwindows([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDoesBackingStore(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDoesSaveUnders(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisableAccessControl([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayCells([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayHeight([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayHeightMM([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayKeycodes([NativeTypeName("Display *")] _XDisplay* param0, int* param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayPlanes([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayWidth([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDisplayWidthMM([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawArc([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawArcs([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, XArc* param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawImageString([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, [NativeTypeName("const char *")] sbyte* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawImageString16([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, [NativeTypeName("const XChar2b *")] XChar2b* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawLine([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, int param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawLines([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, XPoint* param3, int param4, int param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawPoint([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawPoints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, XPoint* param3, int param4, int param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawRectangle([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawRectangles([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, XRectangle* param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawSegments([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, XSegment* param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawString([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, [NativeTypeName("const char *")] sbyte* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawString16([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, [NativeTypeName("const XChar2b *")] XChar2b* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawText([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, XTextItem* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDrawText16([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, XTextItem16* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XEnableAccessControl([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XEventsQueued([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFetchName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("char **")] sbyte** param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillArc([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillArcs([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, XArc* param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillPolygon([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, XPoint* param3, int param4, int param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillRectangle([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFillRectangles([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, XRectangle* param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFlush([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XForceScreenSaver([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFree(void* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeColormap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeColors([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("unsigned long *")] nuint* param2, int param3, [NativeTypeName("unsigned long")] nuint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeCursor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Cursor")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeExtensionList([NativeTypeName("char **")] sbyte** param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeFont([NativeTypeName("Display *")] _XDisplay* param0, XFontStruct* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeFontInfo([NativeTypeName("char **")] sbyte** param0, XFontStruct* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeFontNames([NativeTypeName("char **")] sbyte** param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeFontPath([NativeTypeName("char **")] sbyte** param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeGC([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreeModifiermap(XModifierKeymap* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFreePixmap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Pixmap")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGeometry([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8, int* param9, int* param10, int* param11, int* param12);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetErrorDatabaseText([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char *")] sbyte* param4, int param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetErrorText([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetFontProperty(XFontStruct* param0, [NativeTypeName("Atom")] nuint param1, [NativeTypeName("unsigned long *")] nuint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetGCValues([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("unsigned long")] nuint param2, XGCValues* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetGeometry([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("Window *")] nuint* param2, int* param3, int* param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6, [NativeTypeName("unsigned int *")] uint* param7, [NativeTypeName("unsigned int *")] uint* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetIconName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("char **")] sbyte** param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetInputFocus([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window *")] nuint* param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetKeyboardControl([NativeTypeName("Display *")] _XDisplay* param0, XKeyboardState* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetPointerControl([NativeTypeName("Display *")] _XDisplay* param0, int* param1, int* param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetPointerMapping([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned char *")] byte* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetScreenSaver([NativeTypeName("Display *")] _XDisplay* param0, int* param1, int* param2, int* param3, int* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetTransientForHint([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window *")] nuint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWindowProperty([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom")] nuint param2, [NativeTypeName("long")] nint param3, [NativeTypeName("long")] nint param4, int param5, [NativeTypeName("Atom")] nuint param6, [NativeTypeName("Atom *")] nuint* param7, int* param8, [NativeTypeName("unsigned long *")] nuint* param9, [NativeTypeName("unsigned long *")] nuint* param10, [NativeTypeName("unsigned char **")] byte** param11);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWindowAttributes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XWindowAttributes* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabButton([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] nuint param3, int param4, [NativeTypeName("unsigned int")] uint param5, int param6, int param7, [NativeTypeName("Window")] nuint param8, [NativeTypeName("Cursor")] nuint param9);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabKey([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] nuint param3, int param4, int param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabKeyboard([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, int param4, [NativeTypeName("Time")] nuint param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabPointer([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("unsigned int")] uint param3, int param4, int param5, [NativeTypeName("Window")] nuint param6, [NativeTypeName("Cursor")] nuint param7, [NativeTypeName("Time")] nuint param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGrabServer([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XHeightMMOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XHeightOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XIfEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XEvent *")] union _XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged[Cdecl]<_XDisplay*, union _XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XImageByteOrder([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInstallColormap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeyCode")]
        public static extern byte XKeysymToKeycode([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeySym")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XKillClient([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XID")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XLookupColor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3, XColor* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XLowerWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMapRaised([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMapSubwindows([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMapWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMaskEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("long")] nint param1, [NativeTypeName("XEvent *")] union _XEvent* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMaxCmapsOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMinCmapsOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMoveResizeWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMoveWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XNextEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XEvent *")] union _XEvent* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XNoOp([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XParseColor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, XColor* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XParseGeometry([NativeTypeName("const char *")] sbyte* param0, int* param1, int* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPeekEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XEvent *")] union _XEvent* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPeekIfEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XEvent *")] union _XEvent* param1, [NativeTypeName("int (*)(Display *, XEvent *, XPointer)")] delegate* unmanaged[Cdecl]<_XDisplay*, union _XEvent*, sbyte*, int> param2, [NativeTypeName("XPointer")] sbyte* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPending([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPlanesOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XProtocolRevision([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XProtocolVersion([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPutBackEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XEvent *")] union _XEvent* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPutImage([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, [NativeTypeName("XImage *")] _XImage* param3, int param4, int param5, int param6, int param7, [NativeTypeName("unsigned int")] uint param8, [NativeTypeName("unsigned int")] uint param9);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQLength([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryBestCursor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryBestSize([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("Drawable")] nuint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int *")] uint* param5, [NativeTypeName("unsigned int *")] uint* param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryBestStipple([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryBestTile([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryColor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, XColor* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryColors([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, XColor* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryExtension([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int* param2, int* param3, int* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryKeymap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("char[32]")] sbyte* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryPointer([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window *")] nuint* param2, [NativeTypeName("Window *")] nuint* param3, int* param4, int* param5, int* param6, int* param7, [NativeTypeName("unsigned int *")] uint* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryTextExtents([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, int param3, int* param4, int* param5, int* param6, XCharStruct* param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryTextExtents16([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("const XChar2b *")] XChar2b* param2, int param3, int* param4, int* param5, int* param6, XCharStruct* param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XQueryTree([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window *")] nuint* param2, [NativeTypeName("Window *")] nuint* param3, [NativeTypeName("Window **")] nuint** param4, [NativeTypeName("unsigned int *")] uint* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRaiseWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XReadBitmapFile([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("unsigned int *")] uint* param4, [NativeTypeName("Pixmap *")] nuint* param5, int* param6, int* param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XReadBitmapFileData([NativeTypeName("const char *")] sbyte* param0, [NativeTypeName("unsigned int *")] uint* param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned char **")] byte** param3, int* param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRebindKeysym([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeySym")] nuint param1, [NativeTypeName("KeySym *")] nuint* param2, int param3, [NativeTypeName("const unsigned char *")] byte* param4, int param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRecolorCursor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Cursor")] nuint param1, XColor* param2, XColor* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRefreshKeyboardMapping(XMappingEvent* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRemoveFromSaveSet([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRemoveHost([NativeTypeName("Display *")] _XDisplay* param0, XHostAddress* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRemoveHosts([NativeTypeName("Display *")] _XDisplay* param0, XHostAddress* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XReparentWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window")] nuint param2, int param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XResetScreenSaver([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XResizeWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRestackWindows([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window *")] nuint* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRotateBuffers([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRotateWindowProperties([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Atom *")] nuint* param2, int param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XScreenCount([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSelectInput([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("long")] nint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSendEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("long")] nint param3, [NativeTypeName("XEvent *")] union _XEvent* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetAccessControl([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetArcMode([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetBackground([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetClipMask([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetClipOrigin([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetClipRectangles([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2, int param3, XRectangle* param4, int param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetCloseDownMode([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetCommand([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("char **")] sbyte** param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetDashes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2, [NativeTypeName("const char *")] sbyte* param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFillRule([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFillStyle([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFont([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("Font")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFontPath([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("char **")] sbyte** param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetForeground([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetFunction([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetGraphicsExposures([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetIconName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetInputFocus([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("Time")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetLineAttributes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("unsigned int")] uint param2, int param3, int param4, int param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetModifierMapping([NativeTypeName("Display *")] _XDisplay* param0, XModifierKeymap* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetPlaneMask([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetPointerMapping([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const unsigned char *")] byte* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetScreenSaver([NativeTypeName("Display *")] _XDisplay* param0, int param1, int param2, int param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetSelectionOwner([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Atom")] nuint param1, [NativeTypeName("Window")] nuint param2, [NativeTypeName("Time")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetState([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("unsigned long")] nuint param2, [NativeTypeName("unsigned long")] nuint param3, int param4, [NativeTypeName("unsigned long")] nuint param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetStipple([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetSubwindowMode([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetTSOrigin([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, int param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetTile([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBackground([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBackgroundPixmap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBorder([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned long")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBorderPixmap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Pixmap")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowBorderWidth([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWindowColormap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Colormap")] nuint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreBuffer([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreBytes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreColor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, XColor* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreColors([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, XColor* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStoreNamedColor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("unsigned long")] nuint param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSync([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextExtents(XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, int* param3, int* param4, int* param5, XCharStruct* param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextExtents16(XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2, int* param3, int* param4, int* param5, XCharStruct* param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextWidth(XFontStruct* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextWidth16(XFontStruct* param0, [NativeTypeName("const XChar2b *")] XChar2b* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTranslateCoordinates([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window")] nuint param2, int param3, int param4, int* param5, int* param6, [NativeTypeName("Window *")] nuint* param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUndefineCursor([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabButton([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabKey([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("Window")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabKeyboard([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Time")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabPointer([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Time")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUngrabServer([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUninstallColormap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Colormap")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnloadFont([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Font")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnmapSubwindows([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnmapWindow([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XVendorRelease([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWarpPointer([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("Window")] nuint param2, int param3, int param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int")] uint param6, int param7, int param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWidthMMOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWidthOfScreen(Screen* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWindowEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("long")] nint param2, [NativeTypeName("XEvent *")] union _XEvent* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWriteBitmapFile([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("Pixmap")] nuint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, int param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSupportsLocale();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetLocaleModifiers([NativeTypeName("const char *")] sbyte* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XOM")]
        public static extern _XOM* XOpenOM([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("struct _XrmHashBucketRec *")] _XrmHashBucketRec* param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCloseOM([NativeTypeName("XOM")] _XOM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOMValues([NativeTypeName("XOM")] _XOM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOMValues([NativeTypeName("XOM")] _XOM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern _XDisplay* XDisplayOfOM([NativeTypeName("XOM")] _XOM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfOM([NativeTypeName("XOM")] _XOM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XOC")]
        public static extern _XOC* XCreateOC([NativeTypeName("XOM")] _XOM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XDestroyOC([NativeTypeName("XOC")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XOM")]
        public static extern _XOM* XOMOfOC([NativeTypeName("XOC")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetOCValues([NativeTypeName("XOC")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetOCValues([NativeTypeName("XOC")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XFontSet")]
        public static extern _XOC* XCreateFontSet([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("const char *")] sbyte* param1, [NativeTypeName("char ***")] sbyte*** param2, int* param3, [NativeTypeName("char **")] sbyte** param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XFreeFontSet([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XFontSet")] _XOC* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFontsOfFontSet([NativeTypeName("XFontSet")] _XOC* param0, XFontStruct*** param1, [NativeTypeName("char ***")] sbyte*** param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XBaseFontNameListOfFontSet([NativeTypeName("XFontSet")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfFontSet([NativeTypeName("XFontSet")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XContextDependentDrawing([NativeTypeName("XFontSet")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDirectionalDependentDrawing([NativeTypeName("XFontSet")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XContextualDrawing([NativeTypeName("XFontSet")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XFontSetExtents* XExtentsOfFontSet([NativeTypeName("XFontSet")] _XOC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbTextEscapement([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcTextEscapement([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const wchar_t *")] int* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8TextEscapement([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbTextExtents([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, XRectangle* param3, XRectangle* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcTextExtents([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const wchar_t *")] int* param1, int param2, XRectangle* param3, XRectangle* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8TextExtents([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, XRectangle* param3, XRectangle* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbTextPerCharExtents([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, XRectangle* param3, XRectangle* param4, int param5, int* param6, XRectangle* param7, XRectangle* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcTextPerCharExtents([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const wchar_t *")] int* param1, int param2, XRectangle* param3, XRectangle* param4, int param5, int* param6, XRectangle* param7, XRectangle* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8TextPerCharExtents([NativeTypeName("XFontSet")] _XOC* param0, [NativeTypeName("const char *")] sbyte* param1, int param2, XRectangle* param3, XRectangle* param4, int param5, int* param6, XRectangle* param7, XRectangle* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XmbDrawText([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, XmbTextItem* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XwcDrawText([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, XwcTextItem* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void Xutf8DrawText([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("GC")] _XGC* param2, int param3, int param4, XmbTextItem* param5, int param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XmbDrawString([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] _XOC* param2, [NativeTypeName("GC")] _XGC* param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XwcDrawString([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] _XOC* param2, [NativeTypeName("GC")] _XGC* param3, int param4, int param5, [NativeTypeName("const wchar_t *")] int* param6, int param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void Xutf8DrawString([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] _XOC* param2, [NativeTypeName("GC")] _XGC* param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XmbDrawImageString([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] _XOC* param2, [NativeTypeName("GC")] _XGC* param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XwcDrawImageString([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] _XOC* param2, [NativeTypeName("GC")] _XGC* param3, int param4, int param5, [NativeTypeName("const wchar_t *")] int* param6, int param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void Xutf8DrawImageString([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Drawable")] nuint param1, [NativeTypeName("XFontSet")] _XOC* param2, [NativeTypeName("GC")] _XGC* param3, int param4, int param5, [NativeTypeName("const char *")] sbyte* param6, int param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XIM")]
        public static extern _XIM* XOpenIM([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("struct _XrmHashBucketRec *")] _XrmHashBucketRec* param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XCloseIM([NativeTypeName("XIM")] _XIM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetIMValues([NativeTypeName("XIM")] _XIM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetIMValues([NativeTypeName("XIM")] _XIM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern _XDisplay* XDisplayOfIM([NativeTypeName("XIM")] _XIM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XLocaleOfIM([NativeTypeName("XIM")] _XIM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XIC")]
        public static extern _XIC* XCreateIC([NativeTypeName("XIM")] _XIM* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XDestroyIC([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetICFocus([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XUnsetICFocus([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("wchar_t *")]
        public static extern int* XwcResetIC([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XmbResetIC([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* Xutf8ResetIC([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XSetICValues([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* XGetICValues([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XIM")]
        public static extern _XIM* XIMOfIC([NativeTypeName("XIC")] _XIC* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFilterEvent([NativeTypeName("XEvent *")] union _XEvent* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbLookupString([NativeTypeName("XIC")] _XIC* param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("char *")] sbyte* param2, int param3, [NativeTypeName("KeySym *")] nuint* param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcLookupString([NativeTypeName("XIC")] _XIC* param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("wchar_t *")] int* param2, int param3, [NativeTypeName("KeySym *")] nuint* param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8LookupString([NativeTypeName("XIC")] _XIC* param0, [NativeTypeName("XKeyPressedEvent *")] XKeyEvent* param1, [NativeTypeName("char *")] sbyte* param2, int param3, [NativeTypeName("KeySym *")] nuint* param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XVaNestedList")]
        public static extern void* XVaCreateNestedList(int param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRegisterIMInstantiateCallback([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("struct _XrmHashBucketRec *")] _XrmHashBucketRec* param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged[Cdecl]<_XDisplay*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnregisterIMInstantiateCallback([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("struct _XrmHashBucketRec *")] _XrmHashBucketRec* param1, [NativeTypeName("char *")] sbyte* param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("XIDProc")] delegate* unmanaged[Cdecl]<_XDisplay*, sbyte*, sbyte*, void> param4, [NativeTypeName("XPointer")] sbyte* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XInternalConnectionNumbers([NativeTypeName("Display *")] _XDisplay* param0, int** param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XProcessInternalConnection([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XAddConnectionWatch([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged[Cdecl]<_XDisplay*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XRemoveConnectionWatch([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XConnectionWatchProc")] delegate* unmanaged[Cdecl]<_XDisplay*, sbyte*, int, int, sbyte**, void> param1, [NativeTypeName("XPointer")] sbyte* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetAuthorization([NativeTypeName("char *")] sbyte* param0, int param1, [NativeTypeName("char *")] sbyte* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int _Xmbtowc([NativeTypeName("wchar_t *")] int* param0, [NativeTypeName("char *")] sbyte* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int _Xwctomb([NativeTypeName("char *")] sbyte* param0, [NativeTypeName("wchar_t")] int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetEventData([NativeTypeName("Display *")] _XDisplay* param0, XGenericEventCookie* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XFreeEventData([NativeTypeName("Display *")] _XDisplay* param0, XGenericEventCookie* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XClassHint* XAllocClassHint();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XIconSize* XAllocIconSize();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XSizeHints* XAllocSizeHints();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XStandardColormap* XAllocStandardColormap();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XWMHints* XAllocWMHints();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XClipBox([NativeTypeName("Region")] _XRegion* param0, XRectangle* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Region")]
        public static extern _XRegion* XCreateRegion();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* XDefaultString();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDeleteContext([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("XContext")] int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XDestroyRegion([NativeTypeName("Region")] _XRegion* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XEmptyRegion([NativeTypeName("Region")] _XRegion* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XEqualRegion([NativeTypeName("Region")] _XRegion* param0, [NativeTypeName("Region")] _XRegion* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XFindContext([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("XContext")] int param2, [NativeTypeName("XPointer *")] sbyte** param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetClassHint([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XClassHint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetIconSizes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XIconSize** param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetNormalHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetRGBColormaps([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XStandardColormap** param2, int* param3, [NativeTypeName("Atom")] nuint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetSizeHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetStandardColormap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XStandardColormap* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetTextProperty([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XVisualInfo* XGetVisualInfo([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("long")] nint param1, XVisualInfo* param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMClientMachine([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern XWMHints* XGetWMHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMIconName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMNormalHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2, [NativeTypeName("long *")] nint* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetWMSizeHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2, [NativeTypeName("long *")] nint* param3, [NativeTypeName("Atom")] nuint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XGetZoomHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XIntersectRegion([NativeTypeName("Region")] _XRegion* param0, [NativeTypeName("Region")] _XRegion* param1, [NativeTypeName("Region")] _XRegion* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XConvertCase([NativeTypeName("KeySym")] nuint param0, [NativeTypeName("KeySym *")] nuint* param1, [NativeTypeName("KeySym *")] nuint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XLookupString(XKeyEvent* param0, [NativeTypeName("char *")] sbyte* param1, int param2, [NativeTypeName("KeySym *")] nuint* param3, [NativeTypeName("XComposeStatus *")] _XComposeStatus* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XMatchVisualInfo([NativeTypeName("Display *")] _XDisplay* param0, int param1, int param2, int param3, XVisualInfo* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XOffsetRegion([NativeTypeName("Region")] _XRegion* param0, int param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XPointInRegion([NativeTypeName("Region")] _XRegion* param0, int param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Region")]
        public static extern _XRegion* XPolygonRegion(XPoint* param0, int param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XRectInRegion([NativeTypeName("Region")] _XRegion* param0, int param1, int param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSaveContext([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XID")] nuint param1, [NativeTypeName("XContext")] int param2, [NativeTypeName("const char *")] sbyte* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetClassHint([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XClassHint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetIconSizes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XIconSize* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetNormalHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetRGBColormaps([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XStandardColormap* param2, int param3, [NativeTypeName("Atom")] nuint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetSizeHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetStandardProperties([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("Pixmap")] nuint param4, [NativeTypeName("char **")] sbyte** param5, int param6, XSizeHints* param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetTextProperty([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetWMClientMachine([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetWMHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XWMHints* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetWMIconName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetWMName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetWMNormalHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetWMProperties([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XTextProperty* param2, XTextProperty* param3, [NativeTypeName("char **")] sbyte** param4, int param5, XSizeHints* param6, XWMHints* param7, XClassHint* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XmbSetWMProperties([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char **")] sbyte** param4, int param5, XSizeHints* param6, XWMHints* param7, XClassHint* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void Xutf8SetWMProperties([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("char **")] sbyte** param4, int param5, XSizeHints* param6, XWMHints* param7, XClassHint* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetWMSizeHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetRegion([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("GC")] _XGC* param1, [NativeTypeName("Region")] _XRegion* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XSetStandardColormap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XStandardColormap* param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSetZoomHints([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, XSizeHints* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XShrinkRegion([NativeTypeName("Region")] _XRegion* param0, int param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XStringListToTextProperty([NativeTypeName("char **")] sbyte** param0, int param1, XTextProperty* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XSubtractRegion([NativeTypeName("Region")] _XRegion* param0, [NativeTypeName("Region")] _XRegion* param1, [NativeTypeName("Region")] _XRegion* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbTextListToTextProperty([NativeTypeName("Display *")] _XDisplay* display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, XTextProperty* text_prop_return);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcTextListToTextProperty([NativeTypeName("Display *")] _XDisplay* display, [NativeTypeName("wchar_t **")] int** list, int count, XICCEncodingStyle style, XTextProperty* text_prop_return);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8TextListToTextProperty([NativeTypeName("Display *")] _XDisplay* display, [NativeTypeName("char **")] sbyte** list, int count, XICCEncodingStyle style, XTextProperty* text_prop_return);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XwcFreeStringList([NativeTypeName("wchar_t **")] int** list);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XTextPropertyToStringList(XTextProperty* param0, [NativeTypeName("char ***")] sbyte*** param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XmbTextPropertyToTextList([NativeTypeName("Display *")] _XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, int* count_return);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XwcTextPropertyToTextList([NativeTypeName("Display *")] _XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("wchar_t ***")] int*** list_return, int* count_return);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int Xutf8TextPropertyToTextList([NativeTypeName("Display *")] _XDisplay* display, [NativeTypeName("const XTextProperty *")] XTextProperty* text_prop, [NativeTypeName("char ***")] sbyte*** list_return, int* count_return);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnionRectWithRegion(XRectangle* param0, [NativeTypeName("Region")] _XRegion* param1, [NativeTypeName("Region")] _XRegion* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XUnionRegion([NativeTypeName("Region")] _XRegion* param0, [NativeTypeName("Region")] _XRegion* param1, [NativeTypeName("Region")] _XRegion* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XWMGeometry([NativeTypeName("Display *")] _XDisplay* param0, int param1, [NativeTypeName("const char *")] sbyte* param2, [NativeTypeName("const char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, XSizeHints* param5, int* param6, int* param7, int* param8, int* param9, int* param10);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XXorRegion([NativeTypeName("Region")] _XRegion* param0, [NativeTypeName("Region")] _XRegion* param1, [NativeTypeName("Region")] _XRegion* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbIgnoreExtension(int param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("Display *")]
        public static extern _XDisplay* XkbOpenDisplay([NativeTypeName("const char *")] sbyte* param0, int* param1, int* param2, int* param3, int* param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbQueryExtension([NativeTypeName("Display *")] _XDisplay* param0, int* param1, int* param2, int* param3, int* param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbUseExtension([NativeTypeName("Display *")] _XDisplay* param0, int* param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbLibraryVersion(int* param0, int* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint XkbSetXlibControls([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint XkbGetXlibControls([NativeTypeName("Display *")] _XDisplay* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint XkbXlibControlsImplemented();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbSetAtomFuncs([NativeTypeName("XkbInternAtomFunc")] delegate* unmanaged[Cdecl]<_XDisplay*, sbyte*, int, nuint> param0, [NativeTypeName("XkbGetAtomNameFunc")] delegate* unmanaged[Cdecl]<_XDisplay*, nuint, sbyte*> param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym")]
        public static extern nuint XkbKeycodeToKeysym([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeyCode")] byte param1, int param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint XkbKeysymToModifiers([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeySym")] nuint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbLookupKeySym([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeyCode")] byte param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("KeySym *")] nuint* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbLookupKeyBinding([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeySym")] nuint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("char *")] sbyte* param3, int param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbTranslateKeyCode([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("KeyCode")] byte param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int *")] uint* param3, [NativeTypeName("KeySym *")] nuint* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbTranslateKeySym([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("KeySym *")] nuint* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("char *")] sbyte* param3, int param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetAutoRepeatRate([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetAutoRepeatRate([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned int *")] uint* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbChangeEnabledControls([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbDeviceBell([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, int param4, int param5, [NativeTypeName("Atom")] nuint param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbForceDeviceBell([NativeTypeName("Display *")] _XDisplay* param0, int param1, int param2, int param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbDeviceBellEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, int param3, int param4, int param5, [NativeTypeName("Atom")] nuint param6);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbBell([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbForceBell([NativeTypeName("Display *")] _XDisplay* param0, int param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbBellEvent([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Window")] nuint param1, int param2, [NativeTypeName("Atom")] nuint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSelectEvents([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSelectEventDetails([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned long")] nuint param3, [NativeTypeName("unsigned long")] nuint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbNoteMapChanges([NativeTypeName("XkbMapChangesPtr")] _XkbMapChanges* param0, [NativeTypeName("XkbMapNotifyEvent *")] _XkbMapNotifyEvent* param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbNoteNameChanges([NativeTypeName("XkbNameChangesPtr")] _XkbNameChanges* param0, [NativeTypeName("XkbNamesNotifyEvent *")] _XkbNamesNotify* param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetIndicatorState([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int *")] uint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetDeviceIndicatorState([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int *")] uint* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetIndicatorMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned long")] nuint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetIndicatorMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned long")] nuint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetNamedIndicator([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Atom")] nuint param1, int* param2, int* param3, [NativeTypeName("XkbIndicatorMapPtr")] _XkbIndicatorMapRec* param4, int* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetNamedDeviceIndicator([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("Atom")] nuint param4, int* param5, int* param6, [NativeTypeName("XkbIndicatorMapPtr")] _XkbIndicatorMapRec* param7, int* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetNamedIndicator([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("Atom")] nuint param1, int param2, int param3, int param4, [NativeTypeName("XkbIndicatorMapPtr")] _XkbIndicatorMapRec* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetNamedDeviceIndicator([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("Atom")] nuint param4, int param5, int param6, int param7, [NativeTypeName("XkbIndicatorMapPtr")] _XkbIndicatorMapRec* param8);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbLockModifiers([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbLatchModifiers([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbLockGroup([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbLatchGroup([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetServerInternalMods([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetIgnoreLockMods([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbVirtualModsToReal([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int *")] uint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbComputeEffectiveMap([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("XkbKeyTypePtr")] _XkbKeyType* param1, [NativeTypeName("unsigned char *")] byte* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbInitCanonicalKeyTypes([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbDescPtr")]
        public static extern _XkbDesc* XkbAllocKeyboard();

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeKeyboard([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbAllocClientMap([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbAllocServerMap([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeClientMap([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeServerMap([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbKeyTypePtr")]
        public static extern _XkbKeyType* XkbAddKeyType([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("Atom")] nuint param1, int param2, int param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbAllocIndicatorMaps([NativeTypeName("XkbDescPtr")] _XkbDesc* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeIndicatorMaps([NativeTypeName("XkbDescPtr")] _XkbDesc* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbDescPtr")]
        public static extern _XkbDesc* XkbGetMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetUpdatedMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetMapChanges([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDescPtr")] _XkbDesc* param1, [NativeTypeName("XkbMapChangesPtr")] _XkbMapChanges* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbRefreshKeyboardMapping([NativeTypeName("XkbMapNotifyEvent *")] _XkbMapNotifyEvent* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetKeyTypes([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XkbDescPtr")] _XkbDesc* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetKeySyms([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XkbDescPtr")] _XkbDesc* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetKeyActions([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XkbDescPtr")] _XkbDesc* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetKeyBehaviors([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XkbDescPtr")] _XkbDesc* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetVirtualMods([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetKeyExplicitComponents([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XkbDescPtr")] _XkbDesc* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetKeyModifierMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XkbDescPtr")] _XkbDesc* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetKeyVirtualModMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XkbDescPtr")] _XkbDesc* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbAllocControls([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeControls([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetControls([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned long")] nuint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetControls([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned long")] nuint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbNoteControlsChanges([NativeTypeName("XkbControlsChangesPtr")] _XkbControlsChanges* param0, [NativeTypeName("XkbControlsNotifyEvent *")] _XkbControlsNotify* param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbAllocCompatMap([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeCompatMap([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetCompatMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetCompatMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbSymInterpretPtr")]
        public static extern _XkbSymInterpretRec* XkbAddSymInterpret([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("XkbSymInterpretPtr")] _XkbSymInterpretRec* param1, int param2, [NativeTypeName("XkbChangesPtr")] _XkbChanges* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbAllocNames([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, int param2, int param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetNames([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetNames([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("XkbDescPtr")] _XkbDesc* param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbChangeNames([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDescPtr")] _XkbDesc* param1, [NativeTypeName("XkbNameChangesPtr")] _XkbNameChanges* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeNames([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetState([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbStatePtr")] _XkbStateRec* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbDescPtr")] _XkbDesc* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbChangeMap([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDescPtr")] _XkbDesc* param1, [NativeTypeName("XkbMapChangesPtr")] _XkbMapChanges* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetDetectableAutoRepeat([NativeTypeName("Display *")] _XDisplay* param0, int param1, int* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetDetectableAutoRepeat([NativeTypeName("Display *")] _XDisplay* param0, int* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetAutoResetControls([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int *")] uint* param2, [NativeTypeName("unsigned int *")] uint* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetAutoResetControls([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int *")] uint* param1, [NativeTypeName("unsigned int *")] uint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetPerClientControls([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int *")] uint* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetPerClientControls([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int *")] uint* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbCopyKeyType([NativeTypeName("XkbKeyTypePtr")] _XkbKeyType* param0, [NativeTypeName("XkbKeyTypePtr")] _XkbKeyType* param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbCopyKeyTypes([NativeTypeName("XkbKeyTypePtr")] _XkbKeyType* param0, [NativeTypeName("XkbKeyTypePtr")] _XkbKeyType* param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbResizeKeyType([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, int param1, int param2, int param3, int param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("KeySym *")]
        public static extern nuint* XkbResizeKeySyms([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, int param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbAction *")]
        public static extern union _XkbAction* XkbResizeKeyActions([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, int param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbChangeTypesOfKey([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, int param1, int param2, [NativeTypeName("unsigned int")] uint param3, int* param4, [NativeTypeName("XkbMapChangesPtr")] _XkbMapChanges* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbChangeKeycodeRange([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, int param1, int param2, [NativeTypeName("XkbChangesPtr")] _XkbChanges* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbComponentListPtr")]
        public static extern _XkbComponentList* XkbListComponents([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbComponentNamesPtr")] _XkbComponentNames* param2, int* param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeComponentList([NativeTypeName("XkbComponentListPtr")] _XkbComponentList* param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbDescPtr")]
        public static extern _XkbDesc* XkbGetKeyboard([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbDescPtr")]
        public static extern _XkbDesc* XkbGetKeyboardByName([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbComponentNamesPtr")] _XkbComponentNames* param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4, int param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbKeyTypesForCoreSymbols([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, int param1, [NativeTypeName("KeySym *")] nuint* param2, [NativeTypeName("unsigned int")] uint param3, int* param4, [NativeTypeName("KeySym *")] nuint* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbApplyCompatMapToKey([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("KeyCode")] byte param1, [NativeTypeName("XkbChangesPtr")] _XkbChanges* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbUpdateMapFromCore([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("KeyCode")] byte param1, int param2, int param3, [NativeTypeName("KeySym *")] nuint* param4, [NativeTypeName("XkbChangesPtr")] _XkbChanges* param5);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbDeviceLedInfoPtr")]
        public static extern _XkbDeviceLedInfo* XkbAddDeviceLedInfo([NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbResizeDeviceButtonActions([NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param0, [NativeTypeName("unsigned int")] uint param1);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbDeviceInfoPtr")]
        public static extern _XkbDeviceInfo* XkbAllocDeviceInfo([NativeTypeName("unsigned int")] uint param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbFreeDeviceInfo([NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param0, [NativeTypeName("unsigned int")] uint param1, int param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbNoteDeviceChanges([NativeTypeName("XkbDeviceChangesPtr")] _XkbDeviceChanges* param0, [NativeTypeName("XkbExtensionDeviceNotifyEvent *")] _XkbExtensionDeviceNotify* param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("XkbDeviceInfoPtr")]
        public static extern _XkbDeviceInfo* XkbGetDeviceInfo([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetDeviceInfoChanges([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param1, [NativeTypeName("XkbDeviceChangesPtr")] _XkbDeviceChanges* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetDeviceButtonActions([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param1, int param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbGetDeviceLedInfo([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetDeviceInfo([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbChangeDeviceInfo([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param1, [NativeTypeName("XkbDeviceChangesPtr")] _XkbDeviceChanges* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetDeviceLedInfo([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3, [NativeTypeName("unsigned int")] uint param4);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetDeviceButtonActions([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("XkbDeviceInfoPtr")] _XkbDeviceInfo* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("unsigned int")] uint param3);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char")]
        public static extern sbyte XkbToControl([NativeTypeName("char")] sbyte param0);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbSetDebuggingFlags([NativeTypeName("Display *")] _XDisplay* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("char *")] sbyte* param3, [NativeTypeName("unsigned int")] uint param4, [NativeTypeName("unsigned int")] uint param5, [NativeTypeName("unsigned int *")] uint* param6, [NativeTypeName("unsigned int *")] uint* param7);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbApplyVirtualModChanges([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("unsigned int")] uint param1, [NativeTypeName("XkbChangesPtr")] _XkbChanges* param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int XkbUpdateActionVirtualMods([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("XkbAction *")] union _XkbAction* param1, [NativeTypeName("unsigned int")] uint param2);

        [DllImport("X11", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void XkbUpdateKeyTypeVirtualMods([NativeTypeName("XkbDescPtr")] _XkbDesc* param0, [NativeTypeName("XkbKeyTypePtr")] _XkbKeyType* param1, [NativeTypeName("unsigned int")] uint param2, [NativeTypeName("XkbChangesPtr")] _XkbChanges* param3);
    }
}
