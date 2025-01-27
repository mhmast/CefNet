﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_jsdialog_handler_capi.h
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
	/// Callback structure used for asynchronous continuation of JavaScript dialog
	/// requests.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_jsdialog_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_jsdialog_callback_t* self, int success, const cef_string_t* user_input)*
		/// </summary>
		public void* cont;

		/// <summary>
		/// Continue the JS dialog request. Set |success| to true (1) if the OK button
		/// was pressed. The |user_input| value should be specified for prompt
		/// dialogs.
		/// </summary>
		[NativeName("cont")]
		public unsafe void Continue(int success, [Immutable]cef_string_t* user_input)
		{
			fixed (cef_jsdialog_callback_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_jsdialog_callback_t*, int, cef_string_t*, void>)cont)(self, success, user_input);
			}
		}
	}
}

