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
	/// Margin type for PDF printing.
	/// </summary>
	public enum CefPdfPrintMarginType
	{
		/// <summary>
		/// Default margins of 1cm (~0.4 inches).
		/// </summary>
		Default = 0,

		/// <summary>
		/// No margins.
		/// </summary>
		None = 1,

		/// <summary>
		/// Custom margins using the |margin_*| values from cef_pdf_print_settings_t.
		/// </summary>
		Custom = 2,
	}
}

