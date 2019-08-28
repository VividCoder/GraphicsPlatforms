// The following ifdef block is the standard way of creating macros which make exporting
// from a DLL simpler. All files within this DLL are compiled with the DX12NATIVE_EXPORTS
// symbol defined on the command line. This symbol should not be defined on any project
// that uses this DLL. This way any other project whose source files include this file see
// DX12NATIVE_API functions as being imported from a DLL, whereas this DLL sees symbols
// defined with this macro as being exported.
#ifdef DX12NATIVE_EXPORTS
#define DX12NATIVE_API __declspec(dllexport)
#else
#define DX12NATIVE_API __declspec(dllimport)
#endif

// This class is exported from the dll
class DX12NATIVE_API CDx12native {
public:
	CDx12native(void);
	// TODO: add your methods here.
};

extern DX12NATIVE_API int nDx12native;

DX12NATIVE_API int fnDx12native(void);
