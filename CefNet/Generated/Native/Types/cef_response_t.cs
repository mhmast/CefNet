﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_response_capi.h
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
	/// Structure used to represent a web response. The functions of this structure
	/// may be called on any thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_response_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_response_t* self)*
		/// </summary>
		public void* is_read_only;

		/// <summary>
		/// Returns true (1) if this object is read-only.
		/// </summary>
		[NativeName("is_read_only")]
		public unsafe int IsReadOnly()
		{
			fixed (cef_response_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_response_t*, int>)is_read_only)(self);
			}
		}

		/// <summary>
		/// cef_errorcode_t (*)(_cef_response_t* self)*
		/// </summary>
		public void* get_error;

		/// <summary>
		/// Get the response error code. Returns ERR_NONE if there was no error.
		/// </summary>
		[NativeName("get_error")]
		public unsafe CefErrorCode GetError()
		{
			fixed (cef_response_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_response_t*, CefErrorCode>)get_error)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, cef_errorcode_t error)*
		/// </summary>
		public void* set_error;

		/// <summary>
		/// Set the response error code. This can be used by custom scheme handlers to
		/// return errors during initial request processing.
		/// </summary>
		[NativeName("set_error")]
		public unsafe void SetError(CefErrorCode error)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, CefErrorCode, void>)set_error)(self, error);
			}
		}

		/// <summary>
		/// int (*)(_cef_response_t* self)*
		/// </summary>
		public void* get_status;

		/// <summary>
		/// Get the response status code.
		/// </summary>
		[NativeName("get_status")]
		public unsafe int GetStatus()
		{
			fixed (cef_response_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_response_t*, int>)get_status)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, int status)*
		/// </summary>
		public void* set_status;

		/// <summary>
		/// Set the response status code.
		/// </summary>
		[NativeName("set_status")]
		public unsafe void SetStatus(int status)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, int, void>)set_status)(self, status);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_response_t* self)*
		/// </summary>
		public void* get_status_text;

		/// <summary>
		/// Get the response status text.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_status_text")]
		public unsafe cef_string_userfree_t GetStatusText()
		{
			fixed (cef_response_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_userfree_t>)get_status_text)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, const cef_string_t* statusText)*
		/// </summary>
		public void* set_status_text;

		/// <summary>
		/// Set the response status text.
		/// </summary>
		[NativeName("set_status_text")]
		public unsafe void SetStatusText([Immutable]cef_string_t* statusText)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_t*, void>)set_status_text)(self, statusText);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_response_t* self)*
		/// </summary>
		public void* get_mime_type;

		/// <summary>
		/// Get the response mime type.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_mime_type")]
		public unsafe cef_string_userfree_t GetMimeType()
		{
			fixed (cef_response_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_userfree_t>)get_mime_type)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, const cef_string_t* mimeType)*
		/// </summary>
		public void* set_mime_type;

		/// <summary>
		/// Set the response mime type.
		/// </summary>
		[NativeName("set_mime_type")]
		public unsafe void SetMimeType([Immutable]cef_string_t* mimeType)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_t*, void>)set_mime_type)(self, mimeType);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_response_t* self)*
		/// </summary>
		public void* get_charset;

		/// <summary>
		/// Get the response charset.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_charset")]
		public unsafe cef_string_userfree_t GetCharset()
		{
			fixed (cef_response_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_userfree_t>)get_charset)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, const cef_string_t* charset)*
		/// </summary>
		public void* set_charset;

		/// <summary>
		/// Set the response charset.
		/// </summary>
		[NativeName("set_charset")]
		public unsafe void SetCharset([Immutable]cef_string_t* charset)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_t*, void>)set_charset)(self, charset);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_response_t* self, const cef_string_t* name)*
		/// </summary>
		public void* get_header_by_name;

		/// <summary>
		/// Get the value for the specified response header field.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_header_by_name")]
		public unsafe cef_string_userfree_t GetHeaderByName([Immutable]cef_string_t* name)
		{
			fixed (cef_response_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_t*, cef_string_userfree_t>)get_header_by_name)(self, name);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, const cef_string_t* name, const cef_string_t* value, int overwrite)*
		/// </summary>
		public void* set_header_by_name;

		/// <summary>
		/// Set the header |name| to |value|. If |overwrite| is true (1) any existing
		/// values will be replaced with the new value. If |overwrite| is false (0)
		/// any existing values will not be overwritten.
		/// </summary>
		[NativeName("set_header_by_name")]
		public unsafe void SetHeaderByName([Immutable]cef_string_t* name, [Immutable]cef_string_t* value, int overwrite)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_t*, cef_string_t*, int, void>)set_header_by_name)(self, name, value, overwrite);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, cef_string_multimap_t headerMap)*
		/// </summary>
		public void* get_header_map;

		/// <summary>
		/// Get all response header fields.
		/// </summary>
		[NativeName("get_header_map")]
		public unsafe void GetHeaderMap(cef_string_multimap_t headerMap)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_multimap_t, void>)get_header_map)(self, headerMap);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, cef_string_multimap_t headerMap)*
		/// </summary>
		public void* set_header_map;

		/// <summary>
		/// Set all response header fields.
		/// </summary>
		[NativeName("set_header_map")]
		public unsafe void SetHeaderMap(cef_string_multimap_t headerMap)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_multimap_t, void>)set_header_map)(self, headerMap);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_response_t* self)*
		/// </summary>
		public void* get_url;

		/// <summary>
		/// Get the resolved URL after redirects or changed as a result of HSTS.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_url")]
		public unsafe cef_string_userfree_t GetUrl()
		{
			fixed (cef_response_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_userfree_t>)get_url)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_response_t* self, const cef_string_t* url)*
		/// </summary>
		public void* set_url;

		/// <summary>
		/// Set the resolved URL after redirects or changed as a result of HSTS.
		/// </summary>
		[NativeName("set_url")]
		public unsafe void SetUrl([Immutable]cef_string_t* url)
		{
			fixed (cef_response_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_response_t*, cef_string_t*, void>)set_url)(self, url);
			}
		}
	}
}

