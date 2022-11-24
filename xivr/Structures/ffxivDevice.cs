using FFXIVClientStructs.Attributes;
using FFXIVClientStructs.FFXIV.Client.Graphics.Kernel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace xivr.Structures
{
    [StructLayout(LayoutKind.Explicit, Size = 0x220)]
    public struct ffxivDevice
    {
        [FieldOffset(0x008)]
        public unsafe void* ContextArray;

        [FieldOffset(0x010)]
        public unsafe void* RenderThread;

        [FieldOffset(0x058)]
        public unsafe SwapChain* SwapChain;

        // C6 43 ? ? F3 48 0F 2A C8
        // third byte is the offset
        // usually will not above FF
        // mov eax, [rbx + 8Ch]
        // >>> mov byte ptr[rbx + %OFFSET% h], 1
        // cvtsi2ss xmm1, rax
        [FieldOffset(0x062)]
        public byte RequestResolutionChange;

        [FieldOffset(0x06C)]
        public uint Width;

        [FieldOffset(0x070)]
        public uint Height;

        // 42 0F B7 84 B6 90 00 00 00 89 44 24 30 42 0F B7 84 B6 92 00 00 00
        // rax, qword ptr [rsp+4E0h+Point.x]
        // >>> mov  [rdi+ %OFFSET% h], rax
        // jmp short def_?????????
        [FieldOffset(0x180)]
        public uint NewWidth;

        // NewWidth + 4
        [FieldOffset(0x184)]
        public uint NewHeight;

        [FieldOffset(0x1E8)]
        public int D3DFeatureLevel;

        [FieldOffset(0x1F0)]
        public unsafe void* DXGIFactory;

        [FieldOffset(0x1F8)]
        public unsafe void* DXGIOutput;

        [FieldOffset(0x200)]
        public unsafe void* D3D11Forwarder;

        [FieldOffset(0x208)]
        public unsafe void* D3D11DeviceContext;

        [FieldOffset(0x218)]
        public unsafe void* ImmediateContext;

        public unsafe static ffxivDevice** ppInstance { get; internal set; }

        public unsafe static ffxivDevice* Instance()
        {
            if (ppInstance == null)
            {
                throw new InvalidOperationException("Static pointer for Device::Instance is null. Did you forget to call Resolver.Initialize?");
            }

            return *ppInstance;
        }
    }
}
