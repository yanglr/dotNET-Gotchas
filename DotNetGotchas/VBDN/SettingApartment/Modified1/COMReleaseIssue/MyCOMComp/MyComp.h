// MyComp.h : Declaration of the CMyComp

#pragma once
#include "resource.h"       // main symbols

#include "MyCOMComp.h"


// CMyComp

class ATL_NO_VTABLE CMyComp : 
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CMyComp, &CLSID_MyComp>,
	public IMyComp2,
	public IDispatchImpl<IMyComp, &IID_IMyComp, &LIBID_MyCOMCompLib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
public:
	CMyComp()
	{
		::MessageBox(NULL, "Comp created", "MyComp", 0);
	}

	virtual ~CMyComp()
	{
		::MessageBox(NULL, "Comp destroyed", "MyComp", 0);
	}

DECLARE_REGISTRY_RESOURCEID(IDR_MYCOMP)


BEGIN_COM_MAP(CMyComp)
	COM_INTERFACE_ENTRY(IMyComp)
	COM_INTERFACE_ENTRY(IMyComp2)
	COM_INTERFACE_ENTRY(IDispatch)
END_COM_MAP()


	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}
	
	void FinalRelease() 
	{
	}

public:

	STDMETHOD(Method1)(void);
	STDMETHOD(Method2)(void);
};

OBJECT_ENTRY_AUTO(__uuidof(MyComp), CMyComp)
