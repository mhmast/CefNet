﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_response_t.cs
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
	/// Structure used to represent a web response. The functions of this structure
	/// may be called on any thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefResponse : CefBaseRefCounted<cef_response_t>
	{
		internal static unsafe CefResponse Create(IntPtr instance)
		{
			return new CefResponse((cef_response_t*)instance);
		}

		public CefResponse(cef_response_t* instance)
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
		/// Gets and sets the response error code. Returns ERR_NONE if there was no error.
		/// </summary>
		public unsafe virtual CefErrorCode Error
		{
			get
			{
				return SafeCall(NativeInstance->GetError());
			}
			set
			{
				NativeInstance->SetError(value);
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets and sets the response status code.
		/// </summary>
		public unsafe virtual int Status
		{
			get
			{
				return SafeCall(NativeInstance->GetStatus());
			}
			set
			{
				NativeInstance->SetStatus(value);
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets and sets the response status text.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string StatusText
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetStatusText()));
			}
			set
			{
				fixed (char* s0 = value)
				{
					var cstr0 = new cef_string_t { Str = s0, Length = value != null ? value.Length : 0 };
					NativeInstance->SetStatusText(&cstr0);
				}
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets and sets the response mime type.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string MimeType
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetMimeType()));
			}
			set
			{
				fixed (char* s0 = value)
				{
					var cstr0 = new cef_string_t { Str = s0, Length = value != null ? value.Length : 0 };
					NativeInstance->SetMimeType(&cstr0);
				}
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets and sets the response charset.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string Charset
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetCharset()));
			}
			set
			{
				fixed (char* s0 = value)
				{
					var cstr0 = new cef_string_t { Str = s0, Length = value != null ? value.Length : 0 };
					NativeInstance->SetCharset(&cstr0);
				}
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets and sets the resolved URL after redirects or changed as a result of HSTS.
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
		/// Get the value for the specified response header field.
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
		/// any existing values will not be overwritten.
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
		/// Get all response header fields.
		/// </summary>
		public unsafe virtual void GetHeaderMap(CefStringMultimap headerMap)
		{
			NativeInstance->GetHeaderMap(headerMap);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Set all response header fields.
		/// </summary>
		public unsafe virtual void SetHeaderMap(CefStringMultimap headerMap)
		{
			NativeInstance->SetHeaderMap(headerMap);
			GC.KeepAlive(this);
		}
	}
}
