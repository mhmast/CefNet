﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_urlrequest_client_t.cs
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
	/// Structure that should be implemented by the cef_urlrequest_t client. The
	/// functions of this structure will be called on the same thread that created
	/// the request unless otherwise documented.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefUrlRequestClient : CefBaseRefCounted<cef_urlrequest_client_t>, ICefUrlRequestClientPrivate
	{
#if NET_LESS_5_0
		private static readonly OnRequestCompleteDelegate fnOnRequestComplete = OnRequestCompleteImpl;

		private static readonly OnUploadProgressDelegate fnOnUploadProgress = OnUploadProgressImpl;

		private static readonly OnDownloadProgressDelegate fnOnDownloadProgress = OnDownloadProgressImpl;

		private static readonly OnDownloadDataDelegate fnOnDownloadData = OnDownloadDataImpl;

		private static readonly GetAuthCredentialsDelegate fnGetAuthCredentials = GetAuthCredentialsImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefUrlRequestClient Create(IntPtr instance)
		{
			return new CefUrlRequestClient((cef_urlrequest_client_t*)instance);
		}

		public CefUrlRequestClient()
		{
			cef_urlrequest_client_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->on_request_complete = (void*)Marshal.GetFunctionPointerForDelegate(fnOnRequestComplete);
			self->on_upload_progress = (void*)Marshal.GetFunctionPointerForDelegate(fnOnUploadProgress);
			self->on_download_progress = (void*)Marshal.GetFunctionPointerForDelegate(fnOnDownloadProgress);
			self->on_download_data = (void*)Marshal.GetFunctionPointerForDelegate(fnOnDownloadData);
			self->get_auth_credentials = (void*)Marshal.GetFunctionPointerForDelegate(fnGetAuthCredentials);
			#else
			self->on_request_complete = (delegate* unmanaged[Stdcall]<cef_urlrequest_client_t*, cef_urlrequest_t*, void>)&OnRequestCompleteImpl;
			self->on_upload_progress = (delegate* unmanaged[Stdcall]<cef_urlrequest_client_t*, cef_urlrequest_t*, long, long, void>)&OnUploadProgressImpl;
			self->on_download_progress = (delegate* unmanaged[Stdcall]<cef_urlrequest_client_t*, cef_urlrequest_t*, long, long, void>)&OnDownloadProgressImpl;
			self->on_download_data = (delegate* unmanaged[Stdcall]<cef_urlrequest_client_t*, cef_urlrequest_t*, void*, nuint, void>)&OnDownloadDataImpl;
			self->get_auth_credentials = (delegate* unmanaged[Stdcall]<cef_urlrequest_client_t*, int, cef_string_t*, int, cef_string_t*, cef_string_t*, cef_auth_callback_t*, int>)&GetAuthCredentialsImpl;
			#endif
		}

		public CefUrlRequestClient(cef_urlrequest_client_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefUrlRequestClientPrivate.AvoidOnRequestComplete();

		/// <summary>
		/// Notifies the client that the request has completed. Use the
		/// cef_urlrequest_t::GetRequestStatus function to determine if the request
		/// was successful or not.
		/// </summary>
		protected internal unsafe virtual void OnRequestComplete(CefUrlRequest request)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnRequestCompleteDelegate(cef_urlrequest_client_t* self, cef_urlrequest_t* request);

#endif // NET_LESS_5_0
		// void (*)(_cef_urlrequest_client_t* self, _cef_urlrequest_t* request)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnRequestCompleteImpl(cef_urlrequest_client_t* self, cef_urlrequest_t* request)
		{
			var instance = GetInstance((IntPtr)self) as CefUrlRequestClient;
			if (instance == null || ((ICefUrlRequestClientPrivate)instance).AvoidOnRequestComplete())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return;
			}
			instance.OnRequestComplete(CefUrlRequest.Wrap(CefUrlRequest.Create, request));
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefUrlRequestClientPrivate.AvoidOnUploadProgress();

		/// <summary>
		/// Notifies the client of upload progress. |current| denotes the number of
		/// bytes sent so far and |total| is the total size of uploading data (or -1
		/// if chunked upload is enabled). This function will only be called if the
		/// UR_FLAG_REPORT_UPLOAD_PROGRESS flag is set on the request.
		/// </summary>
		protected internal unsafe virtual void OnUploadProgress(CefUrlRequest request, long current, long total)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnUploadProgressDelegate(cef_urlrequest_client_t* self, cef_urlrequest_t* request, long current, long total);

#endif // NET_LESS_5_0
		// void (*)(_cef_urlrequest_client_t* self, _cef_urlrequest_t* request, int64 current, int64 total)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnUploadProgressImpl(cef_urlrequest_client_t* self, cef_urlrequest_t* request, long current, long total)
		{
			var instance = GetInstance((IntPtr)self) as CefUrlRequestClient;
			if (instance == null || ((ICefUrlRequestClientPrivate)instance).AvoidOnUploadProgress())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return;
			}
			instance.OnUploadProgress(CefUrlRequest.Wrap(CefUrlRequest.Create, request), current, total);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefUrlRequestClientPrivate.AvoidOnDownloadProgress();

		/// <summary>
		/// Notifies the client of download progress. |current| denotes the number of
		/// bytes received up to the call and |total| is the expected total size of
		/// the response (or -1 if not determined).
		/// </summary>
		protected internal unsafe virtual void OnDownloadProgress(CefUrlRequest request, long current, long total)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnDownloadProgressDelegate(cef_urlrequest_client_t* self, cef_urlrequest_t* request, long current, long total);

#endif // NET_LESS_5_0
		// void (*)(_cef_urlrequest_client_t* self, _cef_urlrequest_t* request, int64 current, int64 total)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnDownloadProgressImpl(cef_urlrequest_client_t* self, cef_urlrequest_t* request, long current, long total)
		{
			var instance = GetInstance((IntPtr)self) as CefUrlRequestClient;
			if (instance == null || ((ICefUrlRequestClientPrivate)instance).AvoidOnDownloadProgress())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return;
			}
			instance.OnDownloadProgress(CefUrlRequest.Wrap(CefUrlRequest.Create, request), current, total);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefUrlRequestClientPrivate.AvoidOnDownloadData();

		/// <summary>
		/// Called when some part of the response is read. |data| contains the current
		/// bytes received since the last call. This function will not be called if
		/// the UR_FLAG_NO_DOWNLOAD_DATA flag is set on the request.
		/// </summary>
		protected internal unsafe virtual void OnDownloadData(CefUrlRequest request, IntPtr data, long dataLength)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void OnDownloadDataDelegate(cef_urlrequest_client_t* self, cef_urlrequest_t* request, void* data, nuint data_length);

#endif // NET_LESS_5_0
		// void (*)(_cef_urlrequest_client_t* self, _cef_urlrequest_t* request, const void* data, size_t data_length)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void OnDownloadDataImpl(cef_urlrequest_client_t* self, cef_urlrequest_t* request, void* data, nuint data_length)
		{
			var instance = GetInstance((IntPtr)self) as CefUrlRequestClient;
			if (instance == null || ((ICefUrlRequestClientPrivate)instance).AvoidOnDownloadData())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				return;
			}
			instance.OnDownloadData(CefUrlRequest.Wrap(CefUrlRequest.Create, request), unchecked((IntPtr)data), (long)data_length);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefUrlRequestClientPrivate.AvoidGetAuthCredentials();

		/// <summary>
		/// Called on the IO thread when the browser needs credentials from the user.
		/// |isProxy| indicates whether the host is a proxy server. |host| contains
		/// the hostname and |port| contains the port number. Return true (1) to
		/// continue the request and call cef_auth_callback_t::cont() when the
		/// authentication information is available. If the request has an associated
		/// browser/frame then returning false (0) will result in a call to
		/// GetAuthCredentials on the cef_request_handler_t associated with that
		/// browser, if any. Otherwise, returning false (0) will cancel the request
		/// immediately. This function will only be called for requests initiated from
		/// the browser process.
		/// </summary>
		protected internal unsafe virtual bool GetAuthCredentials(bool isProxy, string host, int port, string realm, string scheme, CefAuthCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int GetAuthCredentialsDelegate(cef_urlrequest_client_t* self, int isProxy, cef_string_t* host, int port, cef_string_t* realm, cef_string_t* scheme, cef_auth_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_urlrequest_client_t* self, int isProxy, const cef_string_t* host, int port, const cef_string_t* realm, const cef_string_t* scheme, _cef_auth_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int GetAuthCredentialsImpl(cef_urlrequest_client_t* self, int isProxy, cef_string_t* host, int port, cef_string_t* realm, cef_string_t* scheme, cef_auth_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefUrlRequestClient;
			if (instance == null || ((ICefUrlRequestClientPrivate)instance).AvoidGetAuthCredentials())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.GetAuthCredentials(isProxy != 0, CefString.Read(host), port, CefString.Read(realm), CefString.Read(scheme), CefAuthCallback.Wrap(CefAuthCallback.Create, callback)) ? 1 : 0;
		}
	}
}
