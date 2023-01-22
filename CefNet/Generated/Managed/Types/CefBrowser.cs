﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_browser_t.cs
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
	/// Structure used to represent a browser. When used in the browser process the
	/// functions of this structure may be called on any thread unless otherwise
	/// indicated in the comments. When used in the render process the functions of
	/// this structure may only be called on the main thread.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefBrowser : CefBaseRefCounted<cef_browser_t>
	{
		internal static unsafe CefBrowser Create(IntPtr instance)
		{
			return new CefBrowser((cef_browser_t*)instance);
		}

		public CefBrowser(cef_browser_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether this object is currently valid. This will return false after
		/// cef_life_span_handler_t::OnBeforeClose is called.
		/// </summary>
		public unsafe virtual bool IsValid
		{
			get
			{
				return SafeCall(NativeInstance->IsValid() != 0);
			}
		}

		/// <summary>
		/// Gets the browser host object. This property can only be called in the
		/// browser process.
		/// </summary>
		public unsafe virtual CefBrowserHost Host
		{
			get
			{
				return SafeCall(CefBrowserHost.Wrap(CefBrowserHost.Create, NativeInstance->GetHost()));
			}
		}

		/// <summary>
		/// Gets a value indicating whether the browser can navigate backwards.
		/// </summary>
		public unsafe virtual bool CanGoBack
		{
			get
			{
				return SafeCall(NativeInstance->CanGoBack() != 0);
			}
		}

		/// <summary>
		/// Gets a value indicating whether the browser can navigate forwards.
		/// </summary>
		public unsafe virtual bool CanGoForward
		{
			get
			{
				return SafeCall(NativeInstance->CanGoForward() != 0);
			}
		}

		/// <summary>
		/// Gets a value indicating whether the browser is currently loading.
		/// </summary>
		public unsafe virtual bool IsLoading
		{
			get
			{
				return SafeCall(NativeInstance->IsLoading() != 0);
			}
		}

		/// <summary>
		/// Gets the globally unique identifier for this browser. This value is
		/// also used as the tabId for extension APIs.
		/// </summary>
		public unsafe virtual int Identifier
		{
			get
			{
				return SafeCall(NativeInstance->GetIdentifier());
			}
		}

		/// <summary>
		/// Gets a value indicating whether the browser is a popup.
		/// </summary>
		public unsafe virtual bool IsPopup
		{
			get
			{
				return SafeCall(NativeInstance->IsPopup() != 0);
			}
		}

		/// <summary>
		/// Gets a value indicating whether a document has been loaded in the browser.
		/// </summary>
		public unsafe virtual bool HasDocument
		{
			get
			{
				return SafeCall(NativeInstance->HasDocument() != 0);
			}
		}

		/// <summary>
		/// Gets the main (top-level) frame for the browser. In the browser process
		/// this will return a valid object until after
		/// cef_life_span_handler_t::OnBeforeClose is called. In the renderer process
		/// this will return NULL if the main frame is hosted in a different renderer
		/// process (e.g. for cross-origin sub-frames). The main frame object will
		/// change during cross-origin navigation or re-navigation after renderer
		/// process termination (due to crashes, etc).
		/// </summary>
		public unsafe virtual CefFrame MainFrame
		{
			get
			{
				return SafeCall(CefFrame.Wrap(CefFrame.Create, NativeInstance->GetMainFrame()));
			}
		}

		/// <summary>
		/// Gets the focused frame for the browser.
		/// </summary>
		public unsafe virtual CefFrame FocusedFrame
		{
			get
			{
				return SafeCall(CefFrame.Wrap(CefFrame.Create, NativeInstance->GetFocusedFrame()));
			}
		}

		/// <summary>
		/// Gets the number of frames that currently exist.
		/// </summary>
		public unsafe virtual long FrameCount
		{
			get
			{
				return SafeCall((long)NativeInstance->GetFrameCount());
			}
		}

		/// <summary>
		/// Navigate backwards.
		/// </summary>
		public unsafe virtual void GoBack()
		{
			NativeInstance->GoBack();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Navigate forwards.
		/// </summary>
		public unsafe virtual void GoForward()
		{
			NativeInstance->GoForward();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Reload the current page.
		/// </summary>
		public unsafe virtual void Reload()
		{
			NativeInstance->Reload();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Reload the current page ignoring any cached data.
		/// </summary>
		public unsafe virtual void ReloadIgnoreCache()
		{
			NativeInstance->ReloadIgnoreCache();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Stop loading the page.
		/// </summary>
		public unsafe virtual void StopLoad()
		{
			NativeInstance->StopLoad();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Returns true (1) if this object is pointing to the same handle as |that|
		/// object.
		/// </summary>
		public unsafe virtual bool IsSame(CefBrowser that)
		{
			return SafeCall(NativeInstance->IsSame((that != null) ? that.GetNativeInstance() : null) != 0);
		}

		/// <summary>
		/// Returns the frame with the specified identifier, or NULL if not found.
		/// </summary>
		public unsafe virtual CefFrame GetFrameByIdent(long identifier)
		{
			return SafeCall(CefFrame.Wrap(CefFrame.Create, NativeInstance->GetFrameByIdent(identifier)));
		}

		/// <summary>
		/// Returns the frame with the specified name, or NULL if not found.
		/// </summary>
		public unsafe virtual CefFrame GetFrame(string name)
		{
			fixed (char* s0 = name)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = name != null ? name.Length : 0 };
				return SafeCall(CefFrame.Wrap(CefFrame.Create, NativeInstance->GetFrame(&cstr0)));
			}
		}

		/// <summary>
		/// Returns the identifiers of all existing frames.
		/// </summary>
		public unsafe virtual void GetFrameIdentifiers(ref UIntPtr identifiersCount, ref long identifiers)
		{
			fixed (UIntPtr* p0 = &identifiersCount)
			fixed (long* p1 = &identifiers)
			{
				NativeInstance->GetFrameIdentifiers(p0, p1);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Returns the names of all existing frames.
		/// </summary>
		public unsafe virtual void GetFrameNames(CefStringList names)
		{
			NativeInstance->GetFrameNames(names.GetNativeInstance());
			GC.KeepAlive(this);
		}
	}
}
