// Dx12native.cpp : Defines the exported functions for the DLL.
//

#include "pch.h"
#include "framework.h"
#include "Dx12native.h"


// This is an example of an exported variable
DX12NATIVE_API int nDx12native=0;

// This is an example of an exported function.
DX12NATIVE_API int fnDx12native(void)
{
    return 0;
}

DX12NATIVE_API int initDxNative() {

	return 12;

}

// This is the constructor of a class that has been exported.
CDx12native::CDx12native()
{
    return;
}
