// MyComp.h : Declaration of the CMyComp

#pragma once
#include "resource.h"       // main symbols

#include "ACOMComp.h"

#include <iostream>
using namespace std;

// CMyComp

class ATL_NO_VTABLE CMyComp : 
	public CComObjectRootEx<CComSingleThreadModel>,
	public CComCoClass<CMyComp, &CLSID_MyComp>,
	public IDispatchImpl<IMyComp, &IID_IMyComp, &LIBID_ACOMCompLib, /*wMajor =*/ 1, /*wMinor =*/ 0>
{
private:
	static int count;
	double* p1;
	double* p2;

public:
	CMyComp()
	{
		p1 = new double[10000];
		p2 = new double[10000];
		count = count + 1;
	}

	virtual ~CMyComp()
	{
		delete[] p1;
		delete[] p2;
		cout << "MyComp destroyed" << endl;
	}

DECLARE_REGISTRY_RESOURCEID(IDR_MYCOMP)


BEGIN_COM_MAP(CMyComp)
	COM_INTERFACE_ENTRY(IMyComp)
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

	STDMETHOD(doSomething)(int* pCount);
};

OBJECT_ENTRY_AUTO(__uuidof(MyComp), CMyComp)
