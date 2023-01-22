﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_app_capi.h
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
	/// Implement this structure to provide handler implementations. Methods will be
	/// called by the process and/or thread indicated.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_app_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// void (*)(_cef_app_t* self, const cef_string_t* process_type, _cef_command_line_t* command_line)*
		/// </summary>
		public void* on_before_command_line_processing;

		/// <summary>
		/// Provides an opportunity to view and/or modify command-line arguments
		/// before processing by CEF and Chromium. The |process_type| value will be
		/// NULL for the browser process. Do not keep a reference to the
		/// cef_command_line_t object passed to this function. The
		/// cef_settings_t.command_line_args_disabled value can be used to start with
		/// an NULL command-line object. Any values specified in CefSettings that
		/// equate to command-line arguments will be set before this function is
		/// called. Be cautious when using this function to modify command-line
		/// arguments for non-browser processes as this may result in undefined
		/// behavior including crashes.
		/// </summary>
		[NativeName("on_before_command_line_processing")]
		public unsafe void OnBeforeCommandLineProcessing([Immutable]cef_string_t* process_type, cef_command_line_t* command_line)
		{
			fixed (cef_app_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_app_t*, cef_string_t*, cef_command_line_t*, void>)on_before_command_line_processing)(self, process_type, command_line);
			}
		}

		/// <summary>
		/// void (*)(_cef_app_t* self, _cef_scheme_registrar_t* registrar)*
		/// </summary>
		public void* on_register_custom_schemes;

		/// <summary>
		/// Provides an opportunity to register custom schemes. Do not keep a
		/// reference to the |registrar| object. This function is called on the main
		/// thread for each process and the registered schemes should be the same
		/// across all processes.
		/// </summary>
		[NativeName("on_register_custom_schemes")]
		public unsafe void OnRegisterCustomSchemes(cef_scheme_registrar_t* registrar)
		{
			fixed (cef_app_t* self = &this)
			{
				((delegate* unmanaged[Stdcall]<cef_app_t*, cef_scheme_registrar_t*, void>)on_register_custom_schemes)(self, registrar);
			}
		}

		/// <summary>
		/// _cef_resource_bundle_handler_t* (*)(_cef_app_t* self)*
		/// </summary>
		public void* get_resource_bundle_handler;

		/// <summary>
		/// Return the handler for resource bundle events. If
		/// cef_settings_t.pack_loading_disabled is true (1) a handler must be
		/// returned. If no handler is returned resources will be loaded from pack
		/// files. This function is called by the browser and render processes on
		/// multiple threads.
		/// </summary>
		[NativeName("get_resource_bundle_handler")]
		public unsafe cef_resource_bundle_handler_t* GetResourceBundleHandler()
		{
			fixed (cef_app_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_app_t*, cef_resource_bundle_handler_t*>)get_resource_bundle_handler)(self);
			}
		}

		/// <summary>
		/// _cef_browser_process_handler_t* (*)(_cef_app_t* self)*
		/// </summary>
		public void* get_browser_process_handler;

		/// <summary>
		/// Return the handler for functionality specific to the browser process. This
		/// function is called on multiple threads in the browser process.
		/// </summary>
		[NativeName("get_browser_process_handler")]
		public unsafe cef_browser_process_handler_t* GetBrowserProcessHandler()
		{
			fixed (cef_app_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_app_t*, cef_browser_process_handler_t*>)get_browser_process_handler)(self);
			}
		}

		/// <summary>
		/// _cef_render_process_handler_t* (*)(_cef_app_t* self)*
		/// </summary>
		public void* get_render_process_handler;

		/// <summary>
		/// Return the handler for functionality specific to the render process. This
		/// function is called on the render process main thread.
		/// </summary>
		[NativeName("get_render_process_handler")]
		public unsafe cef_render_process_handler_t* GetRenderProcessHandler()
		{
			fixed (cef_app_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_app_t*, cef_render_process_handler_t*>)get_render_process_handler)(self);
			}
		}
	}
}

