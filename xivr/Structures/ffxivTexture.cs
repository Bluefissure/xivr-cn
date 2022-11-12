using System;
using System.Runtime.InteropServices;
using FFXIVClientStructs.FFXIV.Client.Graphics.Render;

namespace xivr.Structures
{
    [StructLayout(LayoutKind.Explicit, Size = 0xA8)]
    public unsafe struct Texture
    {
        [FieldOffset(0x00)]
        public unsafe void* vtbl;

        [FieldOffset(0x18)]
        public long uk5;

        [FieldOffset(0x20)]
        public Notifier Notifier;

        [FieldOffset(0x38)]
        public uint Width;

        [FieldOffset(0x3C)]
        public uint Height;

        [FieldOffset(0x40)]
        public uint Depth;

        [FieldOffset(0x44)]
        public byte MipLevel;

        [FieldOffset(0x45)]
        public byte Unk_35;

        [FieldOffset(0x46)]
        public byte Unk_36;

        [FieldOffset(0x47)]
        public byte Unk_37;

        [FieldOffset(0x48)]
        public TextureFormat TextureFormat;

        [FieldOffset(0x4C)]
        public uint Flags;

        [FieldOffset(0x50)]
        public unsafe void* D3D11Texture2D;

        [FieldOffset(0x58)]
        public unsafe void* D3D11ShaderResourceView;

        [FieldOffset(0x60)]
        public long uk60;

        [FieldOffset(0x68)]
        public UInt64 D3D11RenderTargetPtr;
    }
}