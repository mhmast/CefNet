﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_preference_capi.h
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
	/// Manage access to preferences. Many built-in preferences are registered by
	/// Chromium. Custom preferences can be registered in
	/// cef_browser_process_handler_t::OnRegisterCustomPreferences.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_preference_manager_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_preference_manager_t* self, const cef_string_t* name)*
		/// </summary>
		public void* has_preference;

		/// <summary>
		/// Returns true (1) if a preference with the specified |name| exists. This
		/// function must be called on the browser process UI thread.
		/// </summary>
		[NativeName("has_preference")]
		public unsafe int HasPreference([Immutable]cef_string_t* name)
		{
			fixed (cef_preference_manager_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_preference_manager_t*, cef_string_t*, int>)has_preference)(self, name);
			}
		}

		/// <summary>
		/// _cef_value_t* (*)(_cef_preference_manager_t* self, const cef_string_t* name)*
		/// </summary>
		public void* get_preference;

		/// <summary>
		/// Returns the value for the preference with the specified |name|. Returns
		/// NULL if the preference does not exist. The returned object contains a copy
		/// of the underlying preference value and modifications to the returned
		/// object will not modify the underlying preference value. This function must
		/// be called on the browser process UI thread.
		/// </summary>
		[NativeName("get_preference")]
		public unsafe cef_value_t* GetPreference([Immutable]cef_string_t* name)
		{
			fixed (cef_preference_manager_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_preference_manager_t*, cef_string_t*, cef_value_t*>)get_preference)(self, name);
			}
		}

		/// <summary>
		/// _cef_dictionary_value_t* (*)(_cef_preference_manager_t* self, int include_defaults)*
		/// </summary>
		public void* get_all_preferences;

		/// <summary>
		/// Returns all preferences as a dictionary. If |include_defaults| is true (1)
		/// then preferences currently at their default value will be included. The
		/// returned object contains a copy of the underlying preference values and
		/// modifications to the returned object will not modify the underlying
		/// preference values. This function must be called on the browser process UI
		/// thread.
		/// </summary>
		[NativeName("get_all_preferences")]
		public unsafe cef_dictionary_value_t* GetAllPreferences(int include_defaults)
		{
			fixed (cef_preference_manager_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_preference_manager_t*, int, cef_dictionary_value_t*>)get_all_preferences)(self, include_defaults);
			}
		}

		/// <summary>
		/// int (*)(_cef_preference_manager_t* self, const cef_string_t* name)*
		/// </summary>
		public void* can_set_preference;

		/// <summary>
		/// Returns true (1) if the preference with the specified |name| can be
		/// modified using SetPreference. As one example preferences set via the
		/// command-line usually cannot be modified. This function must be called on
		/// the browser process UI thread.
		/// </summary>
		[NativeName("can_set_preference")]
		public unsafe int CanSetPreference([Immutable]cef_string_t* name)
		{
			fixed (cef_preference_manager_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_preference_manager_t*, cef_string_t*, int>)can_set_preference)(self, name);
			}
		}

		/// <summary>
		/// int (*)(_cef_preference_manager_t* self, const cef_string_t* name, _cef_value_t* value, cef_string_t* error)*
		/// </summary>
		public void* set_preference;

		/// <summary>
		/// Set the |value| associated with preference |name|. Returns true (1) if the
		/// value is set successfully and false (0) otherwise. If |value| is NULL the
		/// preference will be restored to its default value. If setting the
		/// preference fails then |error| will be populated with a detailed
		/// description of the problem. This function must be called on the browser
		/// process UI thread.
		/// </summary>
		[NativeName("set_preference")]
		public unsafe int SetPreference([Immutable]cef_string_t* name, cef_value_t* value, cef_string_t* error)
		{
			fixed (cef_preference_manager_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_preference_manager_t*, cef_string_t*, cef_value_t*, cef_string_t*, int>)set_preference)(self, name, value, error);
			}
		}
	}
}
