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

namespace CefNet.Internal
{
	sealed partial class CefUrlRequestClientGlue: CefUrlRequestClient, ICefUrlRequestClientPrivate
	{
		private WebViewGlue _implementation;

		public CefUrlRequestClientGlue(WebViewGlue impl)
		{
			_implementation = impl;
		}

		bool ICefUrlRequestClientPrivate.AvoidOnRequestComplete()
		{
			return _implementation.AvoidOnRequestComplete();
		}

		public override void OnRequestComplete(CefUrlRequest request)
		{
			_implementation.OnRequestComplete(request);
		}

		bool ICefUrlRequestClientPrivate.AvoidOnUploadProgress()
		{
			return _implementation.AvoidOnUploadProgress();
		}

		public override void OnUploadProgress(CefUrlRequest request, long current, long total)
		{
			_implementation.OnUploadProgress(request, current, total);
		}

		bool ICefUrlRequestClientPrivate.AvoidOnDownloadProgress()
		{
			return _implementation.AvoidOnDownloadProgress();
		}

		public override void OnDownloadProgress(CefUrlRequest request, long current, long total)
		{
			_implementation.OnDownloadProgress(request, current, total);
		}

		bool ICefUrlRequestClientPrivate.AvoidOnDownloadData()
		{
			return _implementation.AvoidOnDownloadData();
		}

		public override void OnDownloadData(CefUrlRequest request, IntPtr data, long dataLength)
		{
			_implementation.OnDownloadData(request, data, dataLength);
		}

		bool ICefUrlRequestClientPrivate.AvoidGetAuthCredentials()
		{
			return _implementation.AvoidGetAuthCredentials();
		}

		public override bool GetAuthCredentials(bool isProxy, string host, int port, string realm, string scheme, CefAuthCallback callback)
		{
			return _implementation.GetAuthCredentials(isProxy, host, port, realm, scheme, callback);
		}

	}
}