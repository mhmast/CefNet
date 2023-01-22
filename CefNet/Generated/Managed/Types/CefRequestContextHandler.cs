﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_request_context_handler_t.cs
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
	/// Implement this structure to provide handler implementations. The handler
	/// instance will not be released until all objects related to the context have
	/// been destroyed.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefRequestContextHandler : CefBaseRefCounted<cef_request_context_handler_t>, ICefRequestContextHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly OnRequestContextInitializedDelegate fnOnRequestContextInitialized = OnRequestContextInitializedImpl;

		private static readonly GetResourceRequestHandlerDelegate fnGetResourceRequestHandler = GetResourceRequestHandlerImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefRequestContextHandler Create(IntPtr instance)
		{
			return new CefRequestContextHandler((cef_request_context_handler_t*)instance);
		}

		public CefRequestContextHandler()
		{
			cef_request_context_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_request_context_initialized = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRequestContextInitialized);
			self->get_resource_request_handler = (void*)Marshal.GetFunctionPointerForDelegate(fnGetResourceRequestHandler);
			#else
			self->on_request_context_initialized = (delegate* unmanaged[Stdcall]<cef_request_context_handler_t*, cef_request_context_t*, void>)&OnRequestContextInitializedImpl;
			self->get_resource_request_handler = (delegate* unmanaged[Stdcall]<cef_request_context_handler_t*, cef_browser_t*, cef_frame_t*, cef_request_t*, int, int, cef_string_t*, int*, cef_resource_request_handler_t*>)&GetResourceRequestHandlerImpl;
			#endif
		}

		public CefRequestContextHandler(cef_request_context_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestContextHandlerPrivate.AvoidOnRequestContextInitialized();

		/// <summary>
		/// Called on the browser process UI thread immediately after the request
		/// context has been initialized.
		/// </summary>
		protected internal unsafe virtual void OnRequestContextInitialized(ref CefRequestContext requestContext)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRequestContextInitializedDelegate(cef_request_context_handler_t* self, cef_request_context_t* request_context);

#endif // NET_LESS_5_0
		// void (*)(_cef_request_context_handler_t* self, _cef_request_context_t* request_context)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnRequestContextInitializedImpl(cef_request_context_handler_t* self, cef_request_context_t* request_context)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestContextHandler;
			if (instance == null || ((ICefRequestContextHandlerPrivate)instance).AvoidOnRequestContextInitialized())
			{
				return;
			}
			instance.OnRequestContextInitialized(ref *(CefRequestContext*)request_context);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefRequestContextHandlerPrivate.AvoidGetResourceRequestHandler();

		/// <summary>
		/// Called on the browser process IO thread before a resource request is
		/// initiated. The |browser| and |frame| values represent the source of the
		/// request, and may be NULL for requests originating from service workers or
		/// cef_urlrequest_t. |request| represents the request contents and cannot be
		/// modified in this callback. |is_navigation| will be true (1) if the
		/// resource request is a navigation. |is_download| will be true (1) if the
		/// resource request is a download. |request_initiator| is the origin (scheme
		/// + domain) of the page that initiated the request. Set
		/// |disable_default_handling| to true (1) to disable default handling of the
		/// request, in which case it will need to be handled via
		/// cef_resource_request_handler_t::GetResourceHandler or it will be canceled.
		/// To allow the resource load to proceed with default handling return NULL.
		/// To specify a handler for the resource return a
		/// cef_resource_request_handler_t object. This function will not be called if
		/// the client associated with |browser| returns a non-NULL value from
		/// cef_request_handler_t::GetResourceRequestHandler for the same request
		/// (identified by cef_request_t::GetIdentifier).
		/// </summary>
		protected internal unsafe virtual CefResourceRequestHandler GetResourceRequestHandler(CefBrowser browser, CefFrame frame, CefRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref int disableDefaultHandling)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate cef_resource_request_handler_t* GetResourceRequestHandlerDelegate(cef_request_context_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_navigation, int is_download, cef_string_t* request_initiator, int* disable_default_handling);

#endif // NET_LESS_5_0
		// _cef_resource_request_handler_t* (*)(_cef_request_context_handler_t* self, _cef_browser_t* browser, _cef_frame_t* frame, _cef_request_t* request, int is_navigation, int is_download, const cef_string_t* request_initiator, int* disable_default_handling)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe cef_resource_request_handler_t* GetResourceRequestHandlerImpl(cef_request_context_handler_t* self, cef_browser_t* browser, cef_frame_t* frame, cef_request_t* request, int is_navigation, int is_download, cef_string_t* request_initiator, int* disable_default_handling)
		{
			var instance = GetInstance((IntPtr)self) as CefRequestContextHandler;
			if (instance == null || ((ICefRequestContextHandlerPrivate)instance).AvoidGetResourceRequestHandler())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)browser);
				ReleaseIfNonNull((cef_base_ref_counted_t*)frame);
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return default;
			}
			CefResourceRequestHandler rv = instance.GetResourceRequestHandler(CefBrowser.Wrap(CefBrowser.Create, browser), CefFrame.Wrap(CefFrame.Create, frame), CefRequest.Wrap(CefRequest.Create, request), is_navigation != 0, is_download != 0, CefString.Read(request_initiator), ref *disable_default_handling);
			if (rv == null)
				return null;
			return (rv != null) ? rv.GetNativeInstance() : null;
		}
	}
}
