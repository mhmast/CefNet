using CefNet;
using CefNet.Net;

namespace WinFormsCoreApp
{
	internal sealed class CustomShemeHandlerFactory : CefSchemeHandlerFactory
	{
		protected override CefResourceHandler Create(CefBrowser browser, CefFrame frame, string schemeName, CefRequest request)
		{
			if (schemeName == "myapp")
			{
				if (request.Url == "myapp://hello/")
					return new StringSource("Hello world!", "text/html");
				if (request.Url == "myapp://anotherendpoint/")
					return new StringSource("Some text.", "text/html");
			}
			return null;
		}
	}

}
