﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_shared_memory_region_t.cs
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
	/// Structure that wraps platform-dependent share memory region mapping.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefSharedMemoryRegion : CefBaseRefCounted<cef_shared_memory_region_t>
	{
		internal static unsafe CefSharedMemoryRegion Create(IntPtr instance)
		{
			return new CefSharedMemoryRegion((cef_shared_memory_region_t*)instance);
		}

		public CefSharedMemoryRegion(cef_shared_memory_region_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether the mapping is valid.
		/// </summary>
		public unsafe virtual bool IsValid
		{
			get
			{
				return SafeCall(NativeInstance->IsValid() != 0);
			}
		}

		/// <summary>
		/// Returns the size of the mapping in bytes. Returns 0 for invalid instances.
		/// </summary>
		public unsafe virtual long Size()
		{
			return SafeCall((long)NativeInstance->Size());
		}

		/// <summary>
		/// Returns the pointer to the memory. Returns nullptr for invalid instances.
		/// The returned pointer is only valid for the life span of this object.
		/// </summary>
		public unsafe virtual IntPtr Memory()
		{
			return SafeCall(NativeInstance->Memory());
		}
	}
}