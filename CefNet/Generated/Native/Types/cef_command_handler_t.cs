﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_command_handler_capi.h
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
	/// Implement this structure to handle events related to commands. The functions
	/// of this structure will be called on the UI thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_command_handler_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_command_handler_t* self, _cef_browser_t* browser, int command_id, cef_window_open_disposition_t disposition)*
		/// </summary>
		public void* on_chrome_command;

		/// <summary>
		/// Called to execute a Chrome command triggered via menu selection or keyboard
		/// shortcut. Values for |command_id| can be found in the cef_command_ids.h
		/// file. |disposition| provides information about the intended command target.
		/// Return true (1) if the command was handled or false (0) for the default
		/// implementation. For context menu commands this will be called after
		/// cef_context_menu_handler_t::OnContextMenuCommand. Only used with the Chrome
		/// runtime.
		/// </summary>
		[NativeName("on_chrome_command")]
		public unsafe int OnChromeCommand(cef_browser_t* browser, int command_id, CefWindowOpenDisposition disposition)
		{
			fixed (cef_command_handler_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_command_handler_t*, cef_browser_t*, int, CefWindowOpenDisposition, int>)on_chrome_command)(self, browser, command_id, disposition);
			}
		}
	}
}
