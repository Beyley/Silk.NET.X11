using System.Runtime.InteropServices;

namespace Silk.NET.X11
{
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _XkbEvent
    {
        [FieldOffset(0)]
        public int type;

        [FieldOffset(0)]
        [NativeTypeName("XkbAnyEvent")]
        public _XkbAnyEvent any;

        [FieldOffset(0)]
        [NativeTypeName("XkbNewKeyboardNotifyEvent")]
        public _XkbNewKeyboardNotify new_kbd;

        [FieldOffset(0)]
        [NativeTypeName("XkbMapNotifyEvent")]
        public _XkbMapNotifyEvent map;

        [FieldOffset(0)]
        [NativeTypeName("XkbStateNotifyEvent")]
        public _XkbStateNotifyEvent state;

        [FieldOffset(0)]
        [NativeTypeName("XkbControlsNotifyEvent")]
        public _XkbControlsNotify ctrls;

        [FieldOffset(0)]
        [NativeTypeName("XkbIndicatorNotifyEvent")]
        public _XkbIndicatorNotify indicators;

        [FieldOffset(0)]
        [NativeTypeName("XkbNamesNotifyEvent")]
        public _XkbNamesNotify names;

        [FieldOffset(0)]
        [NativeTypeName("XkbCompatMapNotifyEvent")]
        public _XkbCompatMapNotify compat;

        [FieldOffset(0)]
        [NativeTypeName("XkbBellNotifyEvent")]
        public _XkbBellNotify bell;

        [FieldOffset(0)]
        [NativeTypeName("XkbActionMessageEvent")]
        public _XkbActionMessage message;

        [FieldOffset(0)]
        [NativeTypeName("XkbAccessXNotifyEvent")]
        public _XkbAccessXNotify accessx;

        [FieldOffset(0)]
        [NativeTypeName("XkbExtensionDeviceNotifyEvent")]
        public _XkbExtensionDeviceNotify device;

        [FieldOffset(0)]
        [NativeTypeName("XEvent")]
        public union _XEvent core;
    }
}
