﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_resource_handler_t.cs
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
	/// Structure used to implement a custom request handler structure. The
	/// functions of this structure will be called on the IO thread unless otherwise
	/// indicated.
	/// </summary>
	/// <remarks>
	/// Role: Handler
	/// </remarks>
	public unsafe partial class CefResourceHandler : CefBaseRefCounted<cef_resource_handler_t>, ICefResourceHandlerPrivate
	{
#if NET_LESS_5_0
		private static readonly OpenDelegate fnOpen = OpenImpl;

		private static readonly ProcessRequestDelegate fnProcessRequest = ProcessRequestImpl;

		private static readonly GetResponseHeadersDelegate fnGetResponseHeaders = GetResponseHeadersImpl;

		private static readonly SkipDelegate fnSkip = SkipImpl;

		private static readonly ReadDelegate fnRead = ReadImpl;

		private static readonly ReadResponseDelegate fnReadResponse = ReadResponseImpl;

		private static readonly CancelDelegate fnCancel = CancelImpl;

#endif // NET_LESS_5_0
		internal static unsafe CefResourceHandler Create(IntPtr instance)
		{
			return new CefResourceHandler((cef_resource_handler_t*)instance);
		}

		public CefResourceHandler()
		{
			cef_resource_handler_t* self = this.NativeInstance;
			#if NET_LESS_5_0
			self->open = (void*)Marshal.GetFunctionPointerForDelegate(fnOpen);
			self->process_request = (void*)Marshal.GetFunctionPointerForDelegate(fnProcessRequest);
			self->get_response_headers = (void*)Marshal.GetFunctionPointerForDelegate(fnGetResponseHeaders);
			self->skip = (void*)Marshal.GetFunctionPointerForDelegate(fnSkip);
			self->read = (void*)Marshal.GetFunctionPointerForDelegate(fnRead);
			self->read_response = (void*)Marshal.GetFunctionPointerForDelegate(fnReadResponse);
			self->cancel = (void*)Marshal.GetFunctionPointerForDelegate(fnCancel);
			#else
			self->open = (delegate* unmanaged[Stdcall]<cef_resource_handler_t*, cef_request_t*, int*, cef_callback_t*, int>)&OpenImpl;
			self->process_request = (delegate* unmanaged[Stdcall]<cef_resource_handler_t*, cef_request_t*, cef_callback_t*, int>)&ProcessRequestImpl;
			self->get_response_headers = (delegate* unmanaged[Stdcall]<cef_resource_handler_t*, cef_response_t*, long*, cef_string_t*, void>)&GetResponseHeadersImpl;
			self->skip = (delegate* unmanaged[Stdcall]<cef_resource_handler_t*, long, long*, cef_resource_skip_callback_t*, int>)&SkipImpl;
			self->read = (delegate* unmanaged[Stdcall]<cef_resource_handler_t*, void*, int, int*, cef_resource_read_callback_t*, int>)&ReadImpl;
			self->read_response = (delegate* unmanaged[Stdcall]<cef_resource_handler_t*, void*, int, int*, cef_callback_t*, int>)&ReadResponseImpl;
			self->cancel = (delegate* unmanaged[Stdcall]<cef_resource_handler_t*, void>)&CancelImpl;
			#endif
		}

		public CefResourceHandler(cef_resource_handler_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceHandlerPrivate.AvoidOpen();

		/// <summary>
		/// Open the response stream. To handle the request immediately set
		/// |handle_request| to true (1) and return true (1). To decide at a later
		/// time set |handle_request| to false (0), return true (1), and execute
		/// |callback| to continue or cancel the request. To cancel the request
		/// immediately set |handle_request| to true (1) and return false (0). This
		/// function will be called in sequence but not from a dedicated thread. For
		/// backwards compatibility set |handle_request| to false (0) and return false
		/// (0) and the ProcessRequest function will be called.
		/// </summary>
		protected internal unsafe virtual bool Open(CefRequest request, ref int handleRequest, CefCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int OpenDelegate(cef_resource_handler_t* self, cef_request_t* request, int* handle_request, cef_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_resource_handler_t* self, _cef_request_t* request, int* handle_request, _cef_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int OpenImpl(cef_resource_handler_t* self, cef_request_t* request, int* handle_request, cef_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceHandler;
			if (instance == null || ((ICefResourceHandlerPrivate)instance).AvoidOpen())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.Open(CefRequest.Wrap(CefRequest.Create, request), ref *handle_request, CefCallback.Wrap(CefCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceHandlerPrivate.AvoidProcessRequest();

		/// <summary>
		/// Begin processing the request. To handle the request return true (1) and
		/// call cef_callback_t::cont() once the response header information is
		/// available (cef_callback_t::cont() can also be called from inside this
		/// function if header information is available immediately). To cancel the
		/// request return false (0).
		/// WARNING: This function is deprecated. Use Open instead.
		/// </summary>
		protected internal unsafe virtual bool ProcessRequest(CefRequest request, CefCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int ProcessRequestDelegate(cef_resource_handler_t* self, cef_request_t* request, cef_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_resource_handler_t* self, _cef_request_t* request, _cef_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int ProcessRequestImpl(cef_resource_handler_t* self, cef_request_t* request, cef_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceHandler;
			if (instance == null || ((ICefResourceHandlerPrivate)instance).AvoidProcessRequest())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)request);
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.ProcessRequest(CefRequest.Wrap(CefRequest.Create, request), CefCallback.Wrap(CefCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceHandlerPrivate.AvoidGetResponseHeaders();

		/// <summary>
		/// Retrieve response header information. If the response length is not known
		/// set |response_length| to -1 and read_response() will be called until it
		/// returns false (0). If the response length is known set |response_length|
		/// to a positive value and read_response() will be called until it returns
		/// false (0) or the specified number of bytes have been read. Use the
		/// |response| object to set the mime type, http status code and other
		/// optional header values. To redirect the request to a new URL set
		/// |redirectUrl| to the new URL. |redirectUrl| can be either a relative or
		/// fully qualified URL. It is also possible to set |response| to a redirect
		/// http status code and pass the new URL via a Location header. Likewise with
		/// |redirectUrl| it is valid to set a relative or fully qualified URL as the
		/// Location header value. If an error occured while setting up the request
		/// you can call set_error() on |response| to indicate the error condition.
		/// </summary>
		protected internal unsafe virtual void GetResponseHeaders(CefResponse response, ref long responseLength, ref string redirectUrl)
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void GetResponseHeadersDelegate(cef_resource_handler_t* self, cef_response_t* response, long* response_length, cef_string_t* redirectUrl);

#endif // NET_LESS_5_0
		// void (*)(_cef_resource_handler_t* self, _cef_response_t* response, int64* response_length, cef_string_t* redirectUrl)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void GetResponseHeadersImpl(cef_resource_handler_t* self, cef_response_t* response, long* response_length, cef_string_t* redirectUrl)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceHandler;
			if (instance == null || ((ICefResourceHandlerPrivate)instance).AvoidGetResponseHeaders())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)response);
				return;
			}
			string s_redirectUrl = CefString.Read(redirectUrl);
			string s_orig_redirectUrl = s_redirectUrl;
			instance.GetResponseHeaders(CefResponse.Wrap(CefResponse.Create, response), ref *response_length, ref s_redirectUrl);
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceHandlerPrivate.AvoidSkip();

		/// <summary>
		/// Skip response data when requested by a Range header. Skip over and discard
		/// |bytes_to_skip| bytes of response data. If data is available immediately
		/// set |bytes_skipped| to the number of bytes skipped and return true (1). To
		/// read the data at a later time set |bytes_skipped| to 0, return true (1)
		/// and execute |callback| when the data is available. To indicate failure set
		/// |bytes_skipped| to
		/// &lt;
		/// 0 (e.g. -2 for ERR_FAILED) and return false (0). This
		/// function will be called in sequence but not from a dedicated thread.
		/// </summary>
		protected internal unsafe virtual bool Skip(long bytesToSkip, ref long bytesSkipped, CefResourceSkipCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int SkipDelegate(cef_resource_handler_t* self, long bytes_to_skip, long* bytes_skipped, cef_resource_skip_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_resource_handler_t* self, int64 bytes_to_skip, int64* bytes_skipped, _cef_resource_skip_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int SkipImpl(cef_resource_handler_t* self, long bytes_to_skip, long* bytes_skipped, cef_resource_skip_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceHandler;
			if (instance == null || ((ICefResourceHandlerPrivate)instance).AvoidSkip())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.Skip(bytes_to_skip, ref *bytes_skipped, CefResourceSkipCallback.Wrap(CefResourceSkipCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceHandlerPrivate.AvoidRead();

		/// <summary>
		/// Read response data. If data is available immediately copy up to
		/// |bytes_to_read| bytes into |data_out|, set |bytes_read| to the number of
		/// bytes copied, and return true (1). To read the data at a later time keep a
		/// pointer to |data_out|, set |bytes_read| to 0, return true (1) and execute
		/// |callback| when the data is available (|data_out| will remain valid until
		/// the callback is executed). To indicate response completion set
		/// |bytes_read| to 0 and return false (0). To indicate failure set
		/// |bytes_read| to
		/// &lt;
		/// 0 (e.g. -2 for ERR_FAILED) and return false (0). This
		/// function will be called in sequence but not from a dedicated thread. For
		/// backwards compatibility set |bytes_read| to -1 and return false (0) and
		/// the ReadResponse function will be called.
		/// </summary>
		protected internal unsafe virtual bool Read(IntPtr dataOut, int bytesToRead, ref int bytesRead, CefResourceReadCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int ReadDelegate(cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, cef_resource_read_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, _cef_resource_read_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int ReadImpl(cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, cef_resource_read_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceHandler;
			if (instance == null || ((ICefResourceHandlerPrivate)instance).AvoidRead())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.Read(unchecked((IntPtr)data_out), bytes_to_read, ref *bytes_read, CefResourceReadCallback.Wrap(CefResourceReadCallback.Create, callback)) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		extern bool ICefResourceHandlerPrivate.AvoidReadResponse();

		/// <summary>
		/// Read response data. If data is available immediately copy up to
		/// |bytes_to_read| bytes into |data_out|, set |bytes_read| to the number of
		/// bytes copied, and return true (1). To read the data at a later time set
		/// |bytes_read| to 0, return true (1) and call cef_callback_t::cont() when
		/// the data is available. To indicate response completion return false (0).
		/// WARNING: This function is deprecated. Use Skip and Read instead.
		/// </summary>
		protected internal unsafe virtual bool ReadResponse(IntPtr dataOut, int bytesToRead, ref int bytesRead, CefCallback callback)
		{
			return default;
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate int ReadResponseDelegate(cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback);

#endif // NET_LESS_5_0
		// int (*)(_cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, _cef_callback_t* callback)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe int ReadResponseImpl(cef_resource_handler_t* self, void* data_out, int bytes_to_read, int* bytes_read, cef_callback_t* callback)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceHandler;
			if (instance == null || ((ICefResourceHandlerPrivate)instance).AvoidReadResponse())
			{
				ReleaseIfNonNull((cef_base_ref_counted_t*)callback);
				return default;
			}
			return instance.ReadResponse(unchecked((IntPtr)data_out), bytes_to_read, ref *bytes_read, CefCallback.Wrap(CefCallback.Create, callback)) ? 1 : 0;
		}

		/// <summary>
		/// Request processing has been canceled.
		/// </summary>
		protected internal unsafe virtual void Cancel()
		{
		}

#if NET_LESS_5_0
		[UnmanagedFunctionPointer(CallingConvention.Winapi)]
		private unsafe delegate void CancelDelegate(cef_resource_handler_t* self);

#endif // NET_LESS_5_0
		// void (*)(_cef_resource_handler_t* self)*
#if !NET_LESS_5_0
		[UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvStdcall) })]
#endif
		private static unsafe void CancelImpl(cef_resource_handler_t* self)
		{
			var instance = GetInstance((IntPtr)self) as CefResourceHandler;
			if (instance == null)
			{
				return;
			}
			instance.Cancel();
		}
	}
}
