namespace Silk.NET.X11
{
    [NativeTypeName("unsigned int")]
    public enum XEventQueueOwner : uint
    {
        XlibOwnsEventQueue = 0,
        XCBOwnsEventQueue,
    }
}
