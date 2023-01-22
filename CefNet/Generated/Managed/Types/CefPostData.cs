﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_post_data_t.cs
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
	/// Structure used to represent post data for a web request. The functions of
	/// this structure may be called on any thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefPostData : CefBaseRefCounted<cef_post_data_t>
	{
		internal static unsafe CefPostData Create(IntPtr instance)
		{
			return new CefPostData((cef_post_data_t*)instance);
		}

		public CefPostData(cef_post_data_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether this object is read-only.
		/// </summary>
		public unsafe virtual bool IsReadOnly
		{
			get
			{
				return SafeCall(NativeInstance->IsReadOnly() != 0);
			}
		}

		/// <summary>
		/// Gets a value indicating whether the underlying POST data includes elements that are
		/// not represented by this cef_post_data_t object (for example, multi-part
		/// file upload data). Modifying cef_post_data_t objects with excluded
		/// elements may result in the request failing.
		/// </summary>
		public unsafe virtual bool HasExcludedElements
		{
			get
			{
				return SafeCall(NativeInstance->HasExcludedElements() != 0);
			}
		}

		/// <summary>
		/// Gets the number of existing post data elements.
		/// </summary>
		public unsafe virtual long ElementCount
		{
			get
			{
				return SafeCall((long)NativeInstance->GetElementCount());
			}
		}

		/// <summary>
		/// Retrieve the post data elements.
		/// </summary>
		public unsafe virtual void GetElements(ref long elementsCount, ref CefPostDataElement elements)
		{
			fixed (long* p0 = &elementsCount)
			{
				cef_post_data_element_t* p1 = (elements != null) ? elements.GetNativeInstance() : null;
				cef_post_data_element_t** pp1 = &p1;
				NativeInstance->GetElements(p0, pp1);
				elements = CefPostDataElement.Wrap(CefPostDataElement.Create, p1);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Remove the specified post data element.  Returns true (1) if the removal
		/// succeeds.
		/// </summary>
		public unsafe virtual bool RemoveElement(CefPostDataElement element)
		{
			return SafeCall(NativeInstance->RemoveElement((element != null) ? element.GetNativeInstance() : null) != 0);
		}

		/// <summary>
		/// Add the specified post data element.  Returns true (1) if the add
		/// succeeds.
		/// </summary>
		public unsafe virtual bool AddElement(CefPostDataElement element)
		{
			return SafeCall(NativeInstance->AddElement((element != null) ? element.GetNativeInstance() : null) != 0);
		}

		/// <summary>
		/// Remove all existing post data elements.
		/// </summary>
		public unsafe virtual void RemoveElements()
		{
			NativeInstance->RemoveElements();
			GC.KeepAlive(this);
		}
	}
}
