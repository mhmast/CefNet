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

namespace CefNet.CApi
{
	/// <summary>
	/// Structure representing the audio parameters for setting up the audio
	/// handler.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_audio_parameters_t
	{
		/// <summary>
		/// Layout of the audio channels
		/// </summary>
		public CefChannelLayout channel_layout;

		/// <summary>
		/// Sample rate
		/// </summary>
		public int sample_rate;

		/// <summary>
		/// Number of frames per buffer
		/// </summary>
		public int frames_per_buffer;
	}
}

