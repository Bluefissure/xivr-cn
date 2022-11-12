#pragma once
#include <d3d11_4.h>

struct stTexture
{
	/* 0x000 */ unsigned long long uk1;
	/* 0x008 */ byte uk2_3[0x8];
	/* 0x010 */ unsigned long long uk4;
	/* 0x018 */ unsigned long long uk5;
	/* 0x020 */ unsigned long long Notifier;
	/* 0x028 */ unsigned long long uk7;
	/* 0x030 */ unsigned long long uk8;
	/* 0x038 */ unsigned int Width;
	/* 0x03C */ unsigned int Height;
	/* 0x040 */ unsigned int Depth;
	/* 0x044 */ byte MipLevel;
	/* 0x045 */ byte unk35;
	/* 0x046 */ byte unk36;
	/* 0x047 */ byte unk37;
	/* 0x048 */ unsigned int TextureFormat;
	/* 0x04C */ unsigned int Flags;
	/* 0x050 */ ID3D11Texture2D* Texture;
	/* 0x058 */ ID3D11ShaderResourceView* ShaderResourceView;
	/* 0x060 */ unsigned long long uk9;
	/* 0x068 */ unsigned long long RenderTargetPtr;
};