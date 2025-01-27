﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_request_capi.h
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
	/// Structure used to represent a web request. The functions of this structure
	/// may be called on any thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_request_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_request_t* self)*
		/// </summary>
		public void* is_read_only;

		/// <summary>
		/// Returns true (1) if this object is read-only.
		/// </summary>
		[NativeName("is_read_only")]
		public unsafe int IsReadOnly()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, int>)is_read_only)(self);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_url;

		/// <summary>
		/// Get the fully qualified URL.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_url")]
		public unsafe cef_string_userfree_t GetUrl()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_userfree_t>)get_url)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, const cef_string_t* url)*
		/// </summary>
		public void* set_url;

		/// <summary>
		/// Set the fully qualified URL.
		/// </summary>
		[NativeName("set_url")]
		public unsafe void SetUrl([Immutable]cef_string_t* url)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_t*, void>)set_url)(self, url);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_method;

		/// <summary>
		/// Get the request function type. The value will default to POST if post data
		/// is provided and GET otherwise.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_method")]
		public unsafe cef_string_userfree_t GetMethod()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_userfree_t>)get_method)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, const cef_string_t* method)*
		/// </summary>
		public void* set_method;

		/// <summary>
		/// Set the request function type.
		/// </summary>
		[NativeName("set_method")]
		public unsafe void SetMethod([Immutable]cef_string_t* method)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_t*, void>)set_method)(self, method);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, const cef_string_t* referrer_url, cef_referrer_policy_t policy)*
		/// </summary>
		public void* set_referrer;

		/// <summary>
		/// Set the referrer URL and policy. If non-NULL the referrer URL must be
		/// fully qualified with an HTTP or HTTPS scheme component. Any username,
		/// password or ref component will be removed.
		/// </summary>
		[NativeName("set_referrer")]
		public unsafe void SetReferrer([Immutable]cef_string_t* referrer_url, CefReferrerPolicy policy)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_t*, CefReferrerPolicy, void>)set_referrer)(self, referrer_url, policy);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_referrer_url;

		/// <summary>
		/// Get the referrer URL.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_referrer_url")]
		public unsafe cef_string_userfree_t GetReferrerUrl()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_userfree_t>)get_referrer_url)(self);
			}
		}

		/// <summary>
		/// cef_referrer_policy_t (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_referrer_policy;

		/// <summary>
		/// Get the referrer policy.
		/// </summary>
		[NativeName("get_referrer_policy")]
		public unsafe CefReferrerPolicy GetReferrerPolicy()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, CefReferrerPolicy>)get_referrer_policy)(self);
			}
		}

		/// <summary>
		/// _cef_post_data_t* (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_post_data;

		/// <summary>
		/// Get the post data.
		/// </summary>
		[NativeName("get_post_data")]
		public unsafe cef_post_data_t* GetPostData()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, cef_post_data_t*>)get_post_data)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, _cef_post_data_t* postData)*
		/// </summary>
		public void* set_post_data;

		/// <summary>
		/// Set the post data.
		/// </summary>
		[NativeName("set_post_data")]
		public unsafe void SetPostData(cef_post_data_t* postData)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_post_data_t*, void>)set_post_data)(self, postData);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, cef_string_multimap_t headerMap)*
		/// </summary>
		public void* get_header_map;

		/// <summary>
		/// Get the header values. Will not include the Referer value if any.
		/// </summary>
		[NativeName("get_header_map")]
		public unsafe void GetHeaderMap(cef_string_multimap_t headerMap)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_multimap_t, void>)get_header_map)(self, headerMap);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, cef_string_multimap_t headerMap)*
		/// </summary>
		public void* set_header_map;

		/// <summary>
		/// Set the header values. If a Referer value exists in the header map it will
		/// be removed and ignored.
		/// </summary>
		[NativeName("set_header_map")]
		public unsafe void SetHeaderMap(cef_string_multimap_t headerMap)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_multimap_t, void>)set_header_map)(self, headerMap);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_request_t* self, const cef_string_t* name)*
		/// </summary>
		public void* get_header_by_name;

		/// <summary>
		/// Returns the first header value for |name| or an NULL string if not found.
		/// Will not return the Referer value if any. Use GetHeaderMap instead if
		/// |name| might have multiple values.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_header_by_name")]
		public unsafe cef_string_userfree_t GetHeaderByName([Immutable]cef_string_t* name)
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_t*, cef_string_userfree_t>)get_header_by_name)(self, name);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, const cef_string_t* name, const cef_string_t* value, int overwrite)*
		/// </summary>
		public void* set_header_by_name;

		/// <summary>
		/// Set the header |name| to |value|. If |overwrite| is true (1) any existing
		/// values will be replaced with the new value. If |overwrite| is false (0)
		/// any existing values will not be overwritten. The Referer value cannot be
		/// set using this function.
		/// </summary>
		[NativeName("set_header_by_name")]
		public unsafe void SetHeaderByName([Immutable]cef_string_t* name, [Immutable]cef_string_t* value, int overwrite)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_t*, cef_string_t*, int, void>)set_header_by_name)(self, name, value, overwrite);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, const cef_string_t* url, const cef_string_t* method, _cef_post_data_t* postData, cef_string_multimap_t headerMap)*
		/// </summary>
		public void* set;

		/// <summary>
		/// Set all values at one time.
		/// </summary>
		[NativeName("set")]
		public unsafe void Set([Immutable]cef_string_t* url, [Immutable]cef_string_t* method, cef_post_data_t* postData, cef_string_multimap_t headerMap)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_t*, cef_string_t*, cef_post_data_t*, cef_string_multimap_t, void>)set)(self, url, method, postData, headerMap);
			}
		}

		/// <summary>
		/// int (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_flags;

		/// <summary>
		/// Get the flags used in combination with cef_urlrequest_t. See
		/// cef_urlrequest_flags_t for supported values.
		/// </summary>
		[NativeName("get_flags")]
		public unsafe int GetFlags()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, int>)get_flags)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, int flags)*
		/// </summary>
		public void* set_flags;

		/// <summary>
		/// Set the flags used in combination with cef_urlrequest_t.  See
		/// cef_urlrequest_flags_t for supported values.
		/// </summary>
		[NativeName("set_flags")]
		public unsafe void SetFlags(int flags)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, int, void>)set_flags)(self, flags);
			}
		}

		/// <summary>
		/// cef_string_userfree_t (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_first_party_for_cookies;

		/// <summary>
		/// Get the URL to the first party for cookies used in combination with
		/// cef_urlrequest_t.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		[NativeName("get_first_party_for_cookies")]
		public unsafe cef_string_userfree_t GetFirstPartyForCookies()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_userfree_t>)get_first_party_for_cookies)(self);
			}
		}

		/// <summary>
		/// void (*)(_cef_request_t* self, const cef_string_t* url)*
		/// </summary>
		public void* set_first_party_for_cookies;

		/// <summary>
		/// Set the URL to the first party for cookies used in combination with
		/// cef_urlrequest_t.
		/// </summary>
		[NativeName("set_first_party_for_cookies")]
		public unsafe void SetFirstPartyForCookies([Immutable]cef_string_t* url)
		{
			fixed (cef_request_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_request_t*, cef_string_t*, void>)set_first_party_for_cookies)(self, url);
			}
		}

		/// <summary>
		/// cef_resource_type_t (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_resource_type;

		/// <summary>
		/// Get the resource type for this request. Only available in the browser
		/// process.
		/// </summary>
		[NativeName("get_resource_type")]
		public unsafe CefResourceType GetResourceType()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, CefResourceType>)get_resource_type)(self);
			}
		}

		/// <summary>
		/// cef_transition_type_t (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_transition_type;

		/// <summary>
		/// Get the transition type for this request. Only available in the browser
		/// process and only applies to requests that represent a main frame or sub-
		/// frame navigation.
		/// </summary>
		[NativeName("get_transition_type")]
		public unsafe CefTransitionType GetTransitionType()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, CefTransitionType>)get_transition_type)(self);
			}
		}

		/// <summary>
		/// uint64 (*)(_cef_request_t* self)*
		/// </summary>
		public void* get_identifier;

		/// <summary>
		/// Returns the globally unique identifier for this request or 0 if not
		/// specified. Can be used by cef_resource_request_handler_t implementations
		/// in the browser process to track a single request across multiple
		/// callbacks.
		/// </summary>
		[NativeName("get_identifier")]
		public unsafe ulong GetIdentifier()
		{
			fixed (cef_request_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_request_t*, ulong>)get_identifier)(self);
			}
		}
	}
}

