// stdafx.h : include file for standard system include files,
// or project specific include files that are used frequently, but
// are changed infrequently
//

#pragma once

struct Type;
// I had to write these two lines get arond the compilation errors. Not a good idea. But again, I would not use AutoDual
typedef Type* _TypePtr; 
#define _TypePtr(x, y) _TypePtr(x)
#import "..\\ALib\\bin\\Debug\\ALib.tlb"
using namespace ALib;

#include <iostream>
#include <tchar.h>
