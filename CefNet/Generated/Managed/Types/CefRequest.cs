﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_request_t.cs
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;
using CefNet.CApi;
using CefNet.Internal;

namespace CefNet
{
	/// <summary>
	/// Structure used to represent a web request. The functions of this structure
	/// may be called on any thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefRequest : CefBaseRefCounted<cef_request_t>
	{
		internal static unsafe CefRequest Create(IntPtr instance)
		{
			return new CefRequest((cef_request_t*)instance);
		}

		public CefRequest(cef_request_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether this object is read-only.
		/// </summary>
		public unsafe virtual bool IsReadOnly
		{
			get
			{
				return SafeCall(NativeInstance->IsReadOnly() != 0);
			}
		}

		/// <summary>
		/// Gets and sets the fully qualified URL.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string Url
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetUrl()));
			}
			set
			{
				fixed (char* s0 = value)
				{
					var cstr0 = new cef_string_t { Str = s0, Length = value != null ? value.Length : 0 };
					NativeInstance->SetUrl(&cstr0);
				}
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets and sets the request function type. The value will default to POST if post data
		/// is provided and GET otherwise.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string Method
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetMethod()));
			}
			set
			{
				fixed (char* s0 = value)
				{
					var cstr0 = new cef_string_t { Str = s0, Length = value != null ? value.Length : 0 };
					NativeInstance->SetMethod(&cstr0);
				}
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Get the referrer URL.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string ReferrerUrl
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetReferrerUrl()));
			}
		}

		/// <summary>
		/// Get the referrer policy.
		/// </summary>
		public unsafe virtual CefReferrerPolicy ReferrerPolicy
		{
			get
			{
				return SafeCall(NativeInstance->GetReferrerPolicy());
			}
		}

		/// <summary>
		/// Gets and sets the post data.
		/// </summary>
		public unsafe virtual CefPostData PostData
		{
			get
			{
				return SafeCall(CefPostData.Wrap(CefPostData.Create, NativeInstance->GetPostData()));
			}
			set
			{
				NativeInstance->SetPostData((value != null) ? value.GetNativeInstance() : null);
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets and sets the flags used in combination with cef_urlrequest_t. See
		/// cef_urlrequest_flags_t for supported values.
		/// </summary>
		public unsafe virtual int Flags
		{
			get
			{
				return SafeCall(NativeInstance->GetFlags());
			}
			set
			{
				NativeInstance->SetFlags(value);
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets and sets the URL to the first party for cookies used in combination with
		/// cef_urlrequest_t.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string FirstPartyForCookies
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetFirstPartyForCookies()));
			}
			set
			{
				fixed (char* s0 = value)
				{
					var cstr0 = new cef_string_t { Str = s0, Length = value != null ? value.Length : 0 };
					NativeInstance->SetFirstPartyForCookies(&cstr0);
				}
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Get the resource type for this request. Only available in the browser
		/// process.
		/// </summary>
		public unsafe virtual CefResourceType ResourceType
		{
			get
			{
				return SafeCall(NativeInstance->GetResourceType());
			}
		}

		/// <summary>
		/// Get the transition type for this request. Only available in the browser
		/// process and only applies to requests that represent a main frame or sub-
		/// frame navigation.
		/// </summary>
		public unsafe virtual CefTransitionType TransitionType
		{
			get
			{
				return SafeCall(NativeInstance->GetTransitionType());
			}
		}

		/// <summary>
		/// Gets the globally unique identifier for this request or 0 if not
		/// specified. Can be used by cef_resource_request_handler_t implementations
		/// in the browser process to track a single request across multiple
		/// callbacks.
		/// </summary>
		public unsafe virtual ulong Identifier
		{
			get
			{
				return SafeCall(NativeInstance->GetIdentifier());
			}
		}

		/// <summary>
		/// Set the referrer URL and policy. If non-NULL the referrer URL must be
		/// fully qualified with an HTTP or HTTPS scheme component. Any username,
		/// password or ref component will be removed.
		/// </summary>
		public unsafe virtual void SetReferrer(string referrerUrl, CefReferrerPolicy policy)
		{
			fixed (char* s0 = referrerUrl)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = referrerUrl != null ? referrerUrl.Length : 0 };
				NativeInstance->SetReferrer(&cstr0, policy);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Get the header values. Will not include the Referer value if any.
		/// </summary>
		public unsafe virtual void GetHeaderMap(CefStringMultimap headerMap)
		{
			NativeInstance->GetHeaderMap(headerMap);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Returns the first header value for |name| or an NULL string if not found.
		/// Will not return the Referer value if any. Use GetHeaderMap instead if
		/// |name| might have multiple values.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string GetHeaderByName(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetHeaderByName(&cstr0)));
			}
		}

		/// <summary>
		/// Set the header |name| to |value|. If |overwrite| is true (1) any existing
		/// values will be replaced with the new value. If |overwrite| is false (0)
		/// any existing values will not be overwritten. The Referer value cannot be
		/// set using this function.
		/// </summary>
		public unsafe virtual void SetHeaderByName(string name, string value, bool overwrite)
		{
			fixed (char* s0 = name)
			fixed (char* s1 = value)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				var cstr1 = new cef_string_t { Str = s1, Length = value != null ? value.Length : 0 };
				NativeInstance->SetHeaderByName(&cstr0, &cstr1, overwrite ? 1 : 0);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Set all values at one time.
		/// </summary>
		public unsafe virtual void Set(string url, string method, CefPostData postData, CefStringMultimap headerMap)
		{
			fixed (char* s0 = url)
			fixed (char* s1 = method)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = url != null ? url.Length : 0 };
				var cstr1 = new cef_string_t { Str = s1, Length = method != null ? method.Length : 0 };
				NativeInstance->Set(&cstr0, &cstr1, (postData != null) ? postData.GetNativeInstance() : null, headerMap);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Set the header values. If a Referer value exists in the header map it will
		/// be removed and ignored.
		/// </summary>
		public unsafe virtual void SetHeaderMap(CefStringMultimap headerMap)
		{
			NativeInstance->SetHeaderMap(headerMap);
			GC.KeepAlive(this);
		}
	}
}
