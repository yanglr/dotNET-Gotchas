// MyComp.cpp : Implementation of CMyComp

#include "stdafx.h"
#include "MyComp.h"
#include ".\mycomp.h"


// CMyComp

int CMyComp::count = 0;

STDMETHODIMP CMyComp::doSomething(int* pCount)
{
	*pCount = count;

	return S_OK;
}
