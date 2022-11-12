#pragma once
#include <d3d11_4.h>
#include "ffxivSwapChain.h"

struct stDevice
{
	/* 0x000 */ byte uk1[0x8];
	/* 0x008 */ unsigned long long ContextArray;
	/* 0x010 */ unsigned long long RenderThread;
	/* 0x018 */ byte uk2[0x40];
	/* 0x058 */ stSwapChain* SwapChain;
	/* 0x060 */ byte uk3[0x188];
	/* 0x1E8 */ unsigned int D3DFeatureLevel;
	/* 0x1EC */ byte uk4[0x4];
	/* 0x1F0 */ IDXGIFactory4* IDXGIFactory;
	/* 0x1F8 */ IDXGIOutput4* IDXGIOutput;
	/* 0x200 */ ID3D11Device4* Device;
	/* 0x208 */ ID3D11DeviceContext4* DeviceContext;
	/* 0x210 */ byte uk5[0x8];
	/* 0x218 */ unsigned long long ImmediateContext;
};