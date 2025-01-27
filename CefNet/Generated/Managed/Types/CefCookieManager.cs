﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_cookie_manager_t.cs
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
	/// Structure used for managing cookies. The functions of this structure may be
	/// called on any thread unless otherwise indicated.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefCookieManager : CefBaseRefCounted<cef_cookie_manager_t>
	{
		internal static unsafe CefCookieManager Create(IntPtr instance)
		{
			return new CefCookieManager((cef_cookie_manager_t*)instance);
		}

		public CefCookieManager(cef_cookie_manager_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Visit all cookies on the UI thread. The returned cookies are ordered by
		/// longest path, then by earliest creation date. Returns false (0) if cookies
		/// cannot be accessed.
		/// </summary>
		public unsafe virtual bool VisitAllCookies(CefCookieVisitor visitor)
		{
			return SafeCall(NativeInstance->VisitAllCookies((visitor != null) ? visitor.GetNativeInstance() : null) != 0);
		}

		/// <summary>
		/// Visit a subset of cookies on the UI thread. The results are filtered by
		/// the given url scheme, host, domain and path. If |includeHttpOnly| is true
		/// (1) HTTP-only cookies will also be included in the results. The returned
		/// cookies are ordered by longest path, then by earliest creation date.
		/// Returns false (0) if cookies cannot be accessed.
		/// </summary>
		public unsafe virtual bool VisitUrlCookies(string url, bool includeHttpOnly, CefCookieVisitor visitor)
		{
			fixed (char* s0 = url)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = url != null ? url.Length : 0 };
				return SafeCall(NativeInstance->VisitUrlCookies(&cstr0, includeHttpOnly ? 1 : 0, (visitor != null) ? visitor.GetNativeInstance() : null) != 0);
			}
		}

		/// <summary>
		/// Sets a cookie given a valid URL and explicit user-provided cookie
		/// attributes. This function expects each attribute to be well-formed. It
		/// will check for disallowed characters (e.g. the &apos;;&apos; character is disallowed
		/// within the cookie value attribute) and fail without setting the cookie if
		/// such characters are found. If |callback| is non-NULL it will be executed
		/// asnychronously on the UI thread after the cookie has been set. Returns
		/// false (0) if an invalid URL is specified or if cookies cannot be accessed.
		/// </summary>
		public unsafe virtual bool SetCookie(string url, CefCookie cookie, CefSetCookieCallback callback)
		{
			fixed (char* s0 = url)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = url != null ? url.Length : 0 };
				return SafeCall(NativeInstance->SetCookie(&cstr0, (cef_cookie_t*)&cookie, (callback != null) ? callback.GetNativeInstance() : null) != 0);
			}
		}

		/// <summary>
		/// Delete all cookies that match the specified parameters. If both |url| and
		/// |cookie_name| values are specified all host and domain cookies matching
		/// both will be deleted. If only |url| is specified all host cookies (but not
		/// domain cookies) irrespective of path will be deleted. If |url| is NULL all
		/// cookies for all hosts and domains will be deleted. If |callback| is non-
		/// NULL it will be executed asnychronously on the UI thread after the cookies
		/// have been deleted. Returns false (0) if a non-NULL invalid URL is
		/// specified or if cookies cannot be accessed. Cookies can alternately be
		/// deleted using the Visit*Cookies() functions.
		/// </summary>
		public unsafe virtual bool DeleteCookies(string url, string cookieName, CefDeleteCookiesCallback callback)
		{
			fixed (char* s0 = url)
			fixed (char* s1 = cookieName)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = url != null ? url.Length : 0 };
				var cstr1 = new cef_string_t { Str = s1, Length = cookieName != null ? cookieName.Length : 0 };
				return SafeCall(NativeInstance->DeleteCookies(&cstr0, &cstr1, (callback != null) ? callback.GetNativeInstance() : null) != 0);
			}
		}

		/// <summary>
		/// Flush the backing store (if any) to disk. If |callback| is non-NULL it
		/// will be executed asnychronously on the UI thread after the flush is
		/// complete. Returns false (0) if cookies cannot be accessed.
		/// </summary>
		public unsafe virtual bool FlushStore(CefCompletionCallback callback)
		{
			return SafeCall(NativeInstance->FlushStore((callback != null) ? callback.GetNativeInstance() : null) != 0);
		}
	}
}
