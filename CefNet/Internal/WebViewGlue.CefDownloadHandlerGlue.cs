using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;

namespace CefNet.Internal
{
	public partial class WebViewGlue
	{
		public void CreateOrDestroyDownloadGlue()
		{
			if (AvoidOnBeforeDownload()
				&& AvoidOnDownloadUpdated())
			{
				this.DownloadGlue = null;
			}
			else if (this.DownloadGlue is null)
			{
				this.DownloadGlue = new CefDownloadHandlerGlue(this);
			}
		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		internal extern bool AvoidOnBeforeDownload();

		internal protected virtual void OnBeforeDownload(CefBrowser browser, CefDownloadItem downloadItem, string suggestedName, CefBeforeDownloadCallback callback)
		{

		}

		[MethodImpl(MethodImplOptions.ForwardRef)]
		internal extern bool AvoidOnDownloadUpdated();

		internal protected virtual void OnDownloadUpdated(CefBrowser browser, CefDownloadItem downloadItem, CefDownloadItemCallback callback)
		{

		}
	}
}
