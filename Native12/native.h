#pragma once

#define NATIVEDX_EXPORTS

#ifdef NATIVEDX_EXPORTS
#define NATIVEDX_API __declspec(dllexport)
#else
#define NATIVEDX_API __declspec(dllimport)
#endif

extern "C"
{

	NATIVEDX_API int InitNativeDx() {

		return 12;

	}

}