﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/internal/cef_types.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet
{
	/// <summary>
	/// Media access permissions used by OnRequestMediaAccessPermission.
	/// </summary>
	[Flags]
	public enum CefMediaAccessPermissionTypes
	{
		/// <summary>
		/// No permission.
		/// </summary>
		None = 0,

		/// <summary>
		/// Device audio capture permission.
		/// </summary>
		DeviceAudioCapture = 1 << 0,

		/// <summary>
		/// Device video capture permission.
		/// </summary>
		DeviceVideoCapture = 1 << 1,

		/// <summary>
		/// Desktop audio capture permission.
		/// </summary>
		DesktopAudioCapture = 1 << 2,

		/// <summary>
		/// Desktop video capture permission.
		/// </summary>
		DesktopVideoCapture = 1 << 3,
	}
}

