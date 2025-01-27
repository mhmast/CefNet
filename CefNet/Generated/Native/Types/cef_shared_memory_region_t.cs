﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_shared_memory_region_capi.h
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
	/// Structure that wraps platform-dependent share memory region mapping.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_shared_memory_region_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_shared_memory_region_t* self)*
		/// </summary>
		public void* is_valid;

		/// <summary>
		/// Returns true (1) if the mapping is valid.
		/// </summary>
		[NativeName("is_valid")]
		public unsafe int IsValid()
		{
			fixed (cef_shared_memory_region_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_shared_memory_region_t*, int>)is_valid)(self);
			}
		}

		/// <summary>
		/// size_t (*)(_cef_shared_memory_region_t* self)*
		/// </summary>
		public void* size;

		/// <summary>
		/// Returns the size of the mapping in bytes. Returns 0 for invalid instances.
		/// </summary>
		[NativeName("size")]
		public unsafe UIntPtr Size()
		{
			fixed (cef_shared_memory_region_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_shared_memory_region_t*, UIntPtr>)size)(self);
			}
		}

		/// <summary>
		/// const void* (*)(_cef_shared_memory_region_t* self)*
		/// </summary>
		public void* memory;

		/// <summary>
		/// Returns the pointer to the memory. Returns nullptr for invalid instances.
		/// The returned pointer is only valid for the life span of this object.
		/// </summary>
		[NativeName("memory")]
		public unsafe IntPtr Memory()
		{
			fixed (cef_shared_memory_region_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_shared_memory_region_t*, IntPtr>)memory)(self);
			}
		}
	}
}

