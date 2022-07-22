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
	/// Implement this structure to handle events related to permission requests. The
	/// functions of this structure will be called on the browser process UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_permission_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_permission_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, const cef_string_t* requesting_url, uint32 requested_permissions, _cef_media_access_callback_t* callback)*
		/// </summary>
		public void* on_request_media_access_permission;

		/// <summary>
		/// Called when a page requests permission to access media. |requesting_url| is
		/// the URL requesting permission. |requested_permissions| is a combination of
		/// values from cef_media_access_permission_types_t that represent the
		/// requested permissions. Return true (1) and call
		/// cef_media_access_callback_t::cont() either in this function or at a later
		/// time to continue or cancel the request. Return false (0) to cancel the
		/// request immediately. This function will not be called if the &quot;--enable-
		/// media-stream&quot; command-line switch is used to grant all permissions.
		/// </summary>
		[NativeName("on_request_media_access_permission")]
		public unsafe int OnRequestMediaAccessPermission(cef_browser_t* browser, cef_frame_t* frame, [Immutable]cef_string_t* requesting_url, uint requested_permissions, cef_media_access_callback_t* callback)
		{
			fixed (cef_permission_handler_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_permission_handler_t*, cef_browser_t*, cef_frame_t*, cef_string_t*, uint, cef_media_access_callback_t*, int>)on_request_media_access_permission)(self, browser, frame, requesting_url, requested_permissions, callback);
			}
		}
	}
}

