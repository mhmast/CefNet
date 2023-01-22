﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_urlrequest_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet.CApi
{
	/// <summary>
	/// Structure used to make a URL request. URL requests are not associated with a
	/// browser instance so no cef_client_t callbacks will be executed. URL requests
	/// can be created on any valid CEF thread in either the browser or render
	/// process. Once created the functions of the URL request object must be
	/// accessed on the same thread that created it.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_urlrequest_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// _cef_request_t* (*)(_cef_urlrequest_t* self)*
		/// </summary>
		public void* get_request;

		/// <summary>
		/// Returns the request object used to create this URL request. The returned
		/// object is read-only and should not be modified.
		/// </summary>
		[NativeName("get_request")]
		public unsafe cef_request_t* GetRequest()
		{
			fixed (cef_urlrequest_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_urlrequest_t*, cef_request_t*>)get_request)(self);
			}
		}

		/// <summary>
		/// _cef_urlrequest_client_t* (*)(_cef_urlrequest_t* self)*
		/// </summary>
		public void* get_client;

		/// <summary>
		/// Returns the client.
		/// </summary>
		[NativeName("get_client")]
		public unsafe cef_urlrequest_client_t* GetClient()
		{
			fixed (cef_urlrequest_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_urlrequest_t*, cef_urlrequest_client_t*>)get_client)(self);
			}
		}

		/// <summary>
		/// cef_urlrequest_status_t (*)(_cef_urlrequest_t* self)*
		/// </summary>
		public void* get_request_status;

		/// <summary>
		/// Returns the request status.
		/// </summary>
		[NativeName("get_request_status")]
		public unsafe CefUrlRequestStatus GetRequestStatus()
		{
			fixed (cef_urlrequest_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_urlrequest_t*, CefUrlRequestStatus>)get_request_status)(self);
			}
		}

		/// <summary>
		/// cef_errorcode_t (*)(_cef_urlrequest_t* self)*
		/// </summary>
		public void* get_request_error;

		/// <summary>
		/// Returns the request error if status is UR_CANCELED or UR_FAILED, or 0
		/// otherwise.
		/// </summary>
		[NativeName("get_request_error")]
		public unsafe CefErrorCode GetRequestError()
		{
			fixed (cef_urlrequest_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_urlrequest_t*, CefErrorCode>)get_request_error)(self);
			}
		}

		/// <summary>
		/// _cef_response_t* (*)(_cef_urlrequest_t* self)*
		/// </summary>
		public void* get_response;

		/// <summary>
		/// Returns the response, or NULL if no response information is available.
		/// Response information will only be available after the upload has
		/// completed. The returned object is read-only and should not be modified.
		/// </summary>
		[NativeName("get_response")]
		public unsafe cef_response_t* GetResponse()
		{
			fixed (cef_urlrequest_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_urlrequest_t*, cef_response_t*>)get_response)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_urlrequest_t* self)*
		/// </summary>
		public void* response_was_cached;

		/// <summary>
		/// Returns true (1) if the response body was served from the cache. This
		/// includes responses for which revalidation was required.
		/// </summary>
		[NativeName("response_was_cached")]
		public unsafe int ResponseWasCached()
		{
			fixed (cef_urlrequest_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_urlrequest_t*, int>)response_was_cached)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_urlrequest_t* self)*
		/// </summary>
		public void* cancel;

		/// <summary>
		/// Cancel the request.
		/// </summary>
		[NativeName("cancel")]
		public unsafe void Cancel()
		{
			fixed (cef_urlrequest_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_urlrequest_t*, void>)cancel)(self);
			}
		}
	}
}

