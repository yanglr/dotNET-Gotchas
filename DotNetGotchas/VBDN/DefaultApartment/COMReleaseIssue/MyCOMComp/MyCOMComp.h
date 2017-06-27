

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0361 */
/* at Mon Sep 06 06:58:26 2004
 */
/* Compiler settings for .\MyCOMComp.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __MyCOMComp_h__
#define __MyCOMComp_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IMyComp2_FWD_DEFINED__
#define __IMyComp2_FWD_DEFINED__
typedef interface IMyComp2 IMyComp2;
#endif 	/* __IMyComp2_FWD_DEFINED__ */


#ifndef __IMyComp_FWD_DEFINED__
#define __IMyComp_FWD_DEFINED__
typedef interface IMyComp IMyComp;
#endif 	/* __IMyComp_FWD_DEFINED__ */


#ifndef __MyComp_FWD_DEFINED__
#define __MyComp_FWD_DEFINED__

#ifdef __cplusplus
typedef class MyComp MyComp;
#else
typedef struct MyComp MyComp;
#endif /* __cplusplus */

#endif 	/* __MyComp_FWD_DEFINED__ */


/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 

void * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void * ); 

#ifndef __IMyComp2_INTERFACE_DEFINED__
#define __IMyComp2_INTERFACE_DEFINED__

/* interface IMyComp2 */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IMyComp2;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("559FF8B9-1E4F-4226-9048-8E93717D55C6")
    IMyComp2 : public IUnknown
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE Method2( void) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IMyComp2Vtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IMyComp2 * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IMyComp2 * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IMyComp2 * This);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *Method2 )( 
            IMyComp2 * This);
        
        END_INTERFACE
    } IMyComp2Vtbl;

    interface IMyComp2
    {
        CONST_VTBL struct IMyComp2Vtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IMyComp2_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IMyComp2_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IMyComp2_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IMyComp2_Method2(This)	\
    (This)->lpVtbl -> Method2(This)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMyComp2_Method2_Proxy( 
    IMyComp2 * This);


void __RPC_STUB IMyComp2_Method2_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IMyComp2_INTERFACE_DEFINED__ */


#ifndef __IMyComp_INTERFACE_DEFINED__
#define __IMyComp_INTERFACE_DEFINED__

/* interface IMyComp */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IMyComp;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("91B083A0-81F3-44EF-88FB-AD1ADBF1865C")
    IMyComp : public IDispatch
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE Method1( void) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IMyCompVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IMyComp * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IMyComp * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IMyComp * This);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfoCount )( 
            IMyComp * This,
            /* [out] */ UINT *pctinfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetTypeInfo )( 
            IMyComp * This,
            /* [in] */ UINT iTInfo,
            /* [in] */ LCID lcid,
            /* [out] */ ITypeInfo **ppTInfo);
        
        HRESULT ( STDMETHODCALLTYPE *GetIDsOfNames )( 
            IMyComp * This,
            /* [in] */ REFIID riid,
            /* [size_is][in] */ LPOLESTR *rgszNames,
            /* [in] */ UINT cNames,
            /* [in] */ LCID lcid,
            /* [size_is][out] */ DISPID *rgDispId);
        
        /* [local] */ HRESULT ( STDMETHODCALLTYPE *Invoke )( 
            IMyComp * This,
            /* [in] */ DISPID dispIdMember,
            /* [in] */ REFIID riid,
            /* [in] */ LCID lcid,
            /* [in] */ WORD wFlags,
            /* [out][in] */ DISPPARAMS *pDispParams,
            /* [out] */ VARIANT *pVarResult,
            /* [out] */ EXCEPINFO *pExcepInfo,
            /* [out] */ UINT *puArgErr);
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *Method1 )( 
            IMyComp * This);
        
        END_INTERFACE
    } IMyCompVtbl;

    interface IMyComp
    {
        CONST_VTBL struct IMyCompVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IMyComp_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IMyComp_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IMyComp_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IMyComp_GetTypeInfoCount(This,pctinfo)	\
    (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)

#define IMyComp_GetTypeInfo(This,iTInfo,lcid,ppTInfo)	\
    (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)

#define IMyComp_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)	\
    (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)

#define IMyComp_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)	\
    (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)


#define IMyComp_Method1(This)	\
    (This)->lpVtbl -> Method1(This)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMyComp_Method1_Proxy( 
    IMyComp * This);


void __RPC_STUB IMyComp_Method1_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IMyComp_INTERFACE_DEFINED__ */



#ifndef __MyCOMCompLib_LIBRARY_DEFINED__
#define __MyCOMCompLib_LIBRARY_DEFINED__

/* library MyCOMCompLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_MyCOMCompLib;

EXTERN_C const CLSID CLSID_MyComp;

#ifdef __cplusplus

class DECLSPEC_UUID("F943FD21-B157-4F14-AD74-A97751839D66")
MyComp;
#endif
#endif /* __MyCOMCompLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


