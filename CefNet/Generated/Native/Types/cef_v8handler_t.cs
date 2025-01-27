﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_v8_capi.h
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
	/// Structure that should be implemented to handle V8 function calls. The
	/// functions of this structure will be called on the thread associated with the
	/// V8 function.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_v8handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_v8handler_t* self, const cef_string_t* name, _cef_v8value_t* object, size_t argumentsCount, const _cef_v8value_t** arguments, _cef_v8value_t** retval, cef_string_t* exception)*
		/// </summary>
		public void* execute;

		/// <summary>
		/// Handle execution of the function identified by |name|. |object| is the
		/// receiver (&apos;this&apos; object) of the function. |arguments| is the list of
		/// arguments passed to the function. If execution succeeds set |retval| to
		/// the function return value. If execution fails set |exception| to the
		/// exception that will be thrown. Return true (1) if execution was handled.
		/// </summary>
		[NativeName("execute")]
		public unsafe int Execute([Immutable]cef_string_t* name, cef_v8value_t* @object, UIntPtr argumentsCount, [Immutable]cef_v8value_t** arguments, cef_v8value_t** retval, cef_string_t* exception)
		{
			fixed (cef_v8handler_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_v8handler_t*, cef_string_t*, cef_v8value_t*, UIntPtr, cef_v8value_t**, cef_v8value_t**, cef_string_t*, int>)execute)(self, name, @object, argumentsCount, arguments, retval, exception);
			}
		}
	}
}

