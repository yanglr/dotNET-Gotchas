// MyComp.cpp : Implementation of CMyComp

#include "stdafx.h"
#include "MyComp.h"
#include ".\mycomp.h"


// CMyComp


STDMETHODIMP CMyComp::Method1(void)
{
	::MessageBox(NULL,  "Method1 called", "MyComp", 0);

	return S_OK;
}

STDMETHODIMP CMyComp::Method2(void)
{
	::MessageBox(NULL,  "Method2 called", "MyComp", 0);

	return S_OK;
}
