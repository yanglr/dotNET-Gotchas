

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0361 */
/* at Mon Jan 17 16:42:16 2005
 */
/* Compiler settings for .\ACOMComp.idl:
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

#ifndef __ACOMComp_h__
#define __ACOMComp_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

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

#ifndef __IMyComp_INTERFACE_DEFINED__
#define __IMyComp_INTERFACE_DEFINED__

/* interface IMyComp */
/* [unique][helpstring][nonextensible][dual][uuid][object] */ 


EXTERN_C const IID IID_IMyComp;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("1D972698-B69E-48DF-90CB-3258410F48B6")
    IMyComp : public IDispatch
    {
    public:
        virtual /* [helpstring][id] */ HRESULT STDMETHODCALLTYPE doSomething( 
            /* [out] */ int *pCount) = 0;
        
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
        
        /* [helpstring][id] */ HRESULT ( STDMETHODCALLTYPE *doSomething )( 
            IMyComp * This,
            /* [out] */ int *pCount);
        
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


#define IMyComp_doSomething(This,pCount)	\
    (This)->lpVtbl -> doSomething(This,pCount)

#endif /* COBJMACROS */


#endif 	/* C style interface */



/* [helpstring][id] */ HRESULT STDMETHODCALLTYPE IMyComp_doSomething_Proxy( 
    IMyComp * This,
    /* [out] */ int *pCount);


void __RPC_STUB IMyComp_doSomething_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IMyComp_INTERFACE_DEFINED__ */



#ifndef __ACOMCompLib_LIBRARY_DEFINED__
#define __ACOMCompLib_LIBRARY_DEFINED__

/* library ACOMCompLib */
/* [helpstring][version][uuid] */ 


EXTERN_C const IID LIBID_ACOMCompLib;

EXTERN_C const CLSID CLSID_MyComp;

#ifdef __cplusplus

class DECLSPEC_UUID("E4EB3427-1E60-4EEC-9C6F-3A82F707DE13")
MyComp;
#endif
#endif /* __ACOMCompLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


