namespace Silk.NET.X11
{
    public unsafe partial struct XModifierKeymap
    {
        public int max_keypermod;

        [NativeTypeName("KeyCode *")]
        public byte* modifiermap;
    }
}
