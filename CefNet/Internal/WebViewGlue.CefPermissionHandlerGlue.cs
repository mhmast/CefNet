﻿using System.Runtime.CompilerServices;

namespace CefNet.Internal
{
	public partial class WebViewGlue
	{
		internal bool AvoidOnRequestMediaAccessPermission()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal bool OnRequestMediaAccessPermission(CefBrowser browser, CefFrame frame, string requestingUrl, uint requestedPermissions, CefMediaAccessCallback callback)
		{
			return OnRequestMediaAccessPermission(browser, frame, requestingUrl, (CefMediaAccessPermissionTypes)requestedPermissions, callback);
		}

		/// <summary>
		/// Called when a page requests permission to access media.
		/// </summary>
		/// <param name="requestingUrl">The URL requesting permission</param>
		/// <param name="requestedPermissions">
		/// A combination of values from <see cref="CefMediaAccessPermissionTypes"/>
		/// that represent the requested permissions.
		/// </param>
		/// <returns>
		/// Return True and call <see cref="CefMediaAccessCallback.Continue"/>
		/// either in this function or at a later time to continue or cancel the request.
		/// Return False to cancel the request immediately.
		/// </returns>
		/// <remarks>
		/// This function will not be called if the &quot;--enable-media-stream&quot;
		/// command-line switch is used to grant all permissions.
		/// </remarks>
		protected virtual bool OnRequestMediaAccessPermission(CefBrowser browser, CefFrame frame, string requestingUrl, CefMediaAccessPermissionTypes requestedPermissions, CefMediaAccessCallback callback)
		{
			return false;
		}
	}
}
