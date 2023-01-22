﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_preference_registrar_t.cs
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
	/// Structure that manages custom preference registrations.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefPreferenceRegistrar : CefBaseScoped<cef_preference_registrar_t>
	{
		internal static unsafe CefPreferenceRegistrar Create(IntPtr instance)
		{
			return new CefPreferenceRegistrar((cef_preference_registrar_t*)instance);
		}

		public CefPreferenceRegistrar(cef_preference_registrar_t* instance)
			: base((cef_base_scoped_t*)instance)
		{
		}

		/// <summary>
		/// Register a preference with the specified |name| and |default_value|. To
		/// avoid conflicts with built-in preferences the |name| value should contain
		/// an application-specific prefix followed by a period (e.g. &quot;myapp.value&quot;).
		/// The contents of |default_value| will be copied. The data type for the
		/// preference will be inferred from |default_value|&apos;s type and cannot be
		/// changed after registration. Returns true (1) on success. Returns false (0)
		/// if |name| is already registered or if |default_value| has an invalid type.
		/// This function must be called from within the scope of the
		/// cef_browser_process_handler_t::OnRegisterCustomPreferences callback.
		/// </summary>
		public unsafe virtual bool AddPreference(string name, CefValue defaultValue)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return SafeCall(NativeInstance->AddPreference(&cstr0, (defaultValue != null) ? defaultValue.GetNativeInstance() : null) != 0);
			}
		}
	}
}