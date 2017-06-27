// ACOMComp.cpp : Implementation of WinMain

#include "stdafx.h"
#include "resource.h"
#include "ACOMComp.h"

#include <iostream>
using namespace std;

class CACOMCompModule : public CAtlExeModuleT< CACOMCompModule >
{
public :
	DECLARE_LIBID(LIBID_ACOMCompLib)
	DECLARE_REGISTRY_APPID_RESOURCEID(IDR_ACOMCOMP, "{7CF7A8CD-6DF1-465D-8536-FB649ED3A3CB}")
};

CACOMCompModule _AtlModule;


//
extern "C" int WINAPI _tWinMain(HINSTANCE /*hInstance*/, HINSTANCE /*hPrevInstance*/, 
                                LPTSTR /*lpCmdLine*/, int nShowCmd)
{
    return _AtlModule.WinMain(nShowCmd);
}

