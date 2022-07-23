﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_permission_handler_capi.h
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
	/// Callback structure used for asynchronous continuation of permission prompts.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_permission_prompt_callback_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_permission_prompt_callback_t* self, cef_permission_request_result_t result)*
		/// </summary>
		public void* cont;

		/// <summary>
		/// Complete the permissions request with the specified |result|.
		/// </summary>
		[NativeName("cont")]
		public unsafe void Continue(CefPermissionRequestResult result)
		{
			fixed (cef_permission_prompt_callback_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_permission_prompt_callback_t*, CefPermissionRequestResult, void>)cont)(self, result);
			}
		}
	}
}

