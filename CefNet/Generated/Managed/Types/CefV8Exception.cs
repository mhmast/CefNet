﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_v8exception_t.cs
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
	/// Structure representing a V8 exception. The functions of this structure may
	/// be called on any render process thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefV8Exception : CefBaseRefCounted<cef_v8exception_t>
	{
		internal static unsafe CefV8Exception Create(IntPtr instance)
		{
			return new CefV8Exception((cef_v8exception_t*)instance);
		}

		public CefV8Exception(cef_v8exception_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets the exception message.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string Message
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetMessage()));
			}
		}

		/// <summary>
		/// Gets the line of source code that the exception occurred within.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string SourceLine
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetSourceLine()));
			}
		}

		/// <summary>
		/// Gets the resource name for the script from where the function causing
		/// the error originates.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string ScriptResourceName
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetScriptResourceName()));
			}
		}

		/// <summary>
		/// Gets the 1-based number of the line where the error occurred or 0 if
		/// the line number is unknown.
		/// </summary>
		public unsafe virtual int LineNumber
		{
			get
			{
				return SafeCall(NativeInstance->GetLineNumber());
			}
		}

		/// <summary>
		/// Gets the index within the script of the first character where the error
		/// occurred.
		/// </summary>
		public unsafe virtual int StartPosition
		{
			get
			{
				return SafeCall(NativeInstance->GetStartPosition());
			}
		}

		/// <summary>
		/// Gets the index within the script of the last character where the error
		/// occurred.
		/// </summary>
		public unsafe virtual int EndPosition
		{
			get
			{
				return SafeCall(NativeInstance->GetEndPosition());
			}
		}

		/// <summary>
		/// Gets the index within the line of the first character where the error
		/// occurred.
		/// </summary>
		public unsafe virtual int StartColumn
		{
			get
			{
				return SafeCall(NativeInstance->GetStartColumn());
			}
		}

		/// <summary>
		/// Gets the index within the line of the last character where the error
		/// occurred.
		/// </summary>
		public unsafe virtual int EndColumn
		{
			get
			{
				return SafeCall(NativeInstance->GetEndColumn());
			}
		}
	}
}
