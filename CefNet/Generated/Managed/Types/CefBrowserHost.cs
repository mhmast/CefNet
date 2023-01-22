﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_browser_host_t.cs
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
	/// Structure used to represent the browser process aspects of a browser. The
	/// functions of this structure can only be called in the browser process. They
	/// may be called on any thread in that process unless otherwise indicated in
	/// the comments.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefBrowserHost : CefBaseRefCounted<cef_browser_host_t>
	{
		internal static unsafe CefBrowserHost Create(IntPtr instance)
		{
			return new CefBrowserHost((cef_browser_host_t*)instance);
		}

		public CefBrowserHost(cef_browser_host_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets the hosted browser object.
		/// </summary>
		public unsafe virtual CefBrowser Browser
		{
			get
			{
				return SafeCall(CefBrowser.Wrap(CefBrowser.Create, NativeInstance->GetBrowser()));
			}
		}

		/// <summary>
		/// Retrieve the window handle (if any) for this browser. If this browser is
		/// wrapped in a cef_browser_view_t this property should be called on the
		/// browser process UI thread and it will return the handle for the top-level
		/// native window.
		/// </summary>
		public unsafe virtual IntPtr WindowHandle
		{
			get
			{
				return SafeCall(NativeInstance->GetWindowHandle());
			}
		}

		/// <summary>
		/// Retrieve the window handle (if any) of the browser that opened this
		/// browser. Will return NULL for non-popup browsers or if this browser is
		/// wrapped in a cef_browser_view_t. This property can be used in combination
		/// with custom handling of modal windows.
		/// </summary>
		public unsafe virtual IntPtr OpenerWindowHandle
		{
			get
			{
				return SafeCall(NativeInstance->GetOpenerWindowHandle());
			}
		}

		/// <summary>
		/// Gets a value indicating whether this browser is wrapped in a cef_browser_view_t.
		/// </summary>
		public unsafe virtual bool HasView
		{
			get
			{
				return SafeCall(NativeInstance->HasView() != 0);
			}
		}

		/// <summary>
		/// Gets the client for this browser.
		/// </summary>
		public unsafe virtual CefClient Client
		{
			get
			{
				return SafeCall(CefClient.Wrap(CefClient.Create, NativeInstance->GetClient()));
			}
		}

		/// <summary>
		/// Gets the request context for this browser.
		/// </summary>
		public unsafe virtual CefRequestContext RequestContext
		{
			get
			{
				return SafeCall(NativeInstance->GetRequestContext());
			}
		}

		/// <summary>
		/// Gets and sets the current zoom level. The default zoom level is 0.0. This property
		/// can only be called on the UI thread.
		/// </summary>
		public unsafe virtual double ZoomLevel
		{
			get
			{
				return SafeCall(NativeInstance->GetZoomLevel());
			}
			set
			{
				NativeInstance->SetZoomLevel(value);
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets a value indicating whether this browser currently has an associated DevTools
		/// browser. Must be called on the browser process UI thread.
		/// </summary>
		public unsafe virtual bool HasDevTools
		{
			get
			{
				return SafeCall(NativeInstance->HasDevTools() != 0);
			}
		}

		/// <summary>
		/// Gets a value indicating whether window rendering is disabled.
		/// </summary>
		public unsafe virtual bool IsWindowRenderingDisabled
		{
			get
			{
				return SafeCall(NativeInstance->IsWindowRenderingDisabled() != 0);
			}
		}

		/// <summary>
		/// Gets or sets the maximum rate in frames per second (fps) that
		/// cef_render_handler_t::OnPaint will be called for a windowless browser. The
		/// actual fps may be lower if the browser cannot generate frames at the
		/// requested rate. The minimum value is 1 and the maximum value is 60
		/// (default 30). This property can only be called on the UI thread.
		/// </summary>
		public unsafe virtual int WindowlessFrameRate
		{
			get
			{
				return SafeCall(NativeInstance->GetWindowlessFrameRate());
			}
			set
			{
				NativeInstance->SetWindowlessFrameRate(value);
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Gets the current visible navigation entry for this browser. This
		/// function can only be called on the UI thread.
		/// </summary>
		public unsafe virtual CefNavigationEntry VisibleNavigationEntry
		{
			get
			{
				return SafeCall(CefNavigationEntry.Wrap(CefNavigationEntry.Create, NativeInstance->GetVisibleNavigationEntry()));
			}
		}

		/// <summary>
		/// Gets the extension hosted in this browser or NULL if no extension is
		/// hosted. See cef_request_context_t::LoadExtension for details.
		/// </summary>
		public unsafe virtual CefExtension Extension
		{
			get
			{
				return SafeCall(CefExtension.Wrap(CefExtension.Create, NativeInstance->GetExtension()));
			}
		}

		/// <summary>
		/// Gets a value indicating whether this browser is hosting an extension background
		/// script. Background hosts do not have a window and are not displayable. See
		/// cef_request_context_t::LoadExtension for details.
		/// </summary>
		public unsafe virtual bool IsBackgroundHost
		{
			get
			{
				return SafeCall(NativeInstance->IsBackgroundHost() != 0);
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether the browser&apos;s audio is muted.  This property can only
		/// be called on the UI thread.
		/// </summary>
		public unsafe virtual bool AudioMuted
		{
			get
			{
				return SafeCall(NativeInstance->IsAudioMuted() != 0);
			}
			set
			{
				NativeInstance->SetAudioMuted(value ? 1 : 0);
				GC.KeepAlive(this);
			}
		}

		/// <summary>
		/// Request that the browser close. The JavaScript &apos;onbeforeunload&apos; event will
		/// be fired. If |force_close| is false (0) the event handler, if any, will be
		/// allowed to prompt the user and the user can optionally cancel the close.
		/// If |force_close| is true (1) the prompt will not be displayed and the
		/// close will proceed. Results in a call to
		/// cef_life_span_handler_t::do_close() if the event handler allows the close
		/// or if |force_close| is true (1). See cef_life_span_handler_t::do_close()
		/// documentation for additional usage information.
		/// </summary>
		public unsafe virtual void CloseBrowser(bool forceClose)
		{
			NativeInstance->CloseBrowser(forceClose ? 1 : 0);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Helper for closing a browser. Call this function from the top-level window
		/// close handler (if any). Internally this calls CloseBrowser(false (0)) if
		/// the close has not yet been initiated. This function returns false (0)
		/// while the close is pending and true (1) after the close has completed. See
		/// close_browser() and cef_life_span_handler_t::do_close() documentation for
		/// additional usage information. This function must be called on the browser
		/// process UI thread.
		/// </summary>
		public unsafe virtual bool TryCloseBrowser()
		{
			return SafeCall(NativeInstance->TryCloseBrowser() != 0);
		}

		/// <summary>
		/// Call to run a file chooser dialog. Only a single file chooser dialog may
		/// be pending at any given time. |mode| represents the type of dialog to
		/// display. |title| to the title to be used for the dialog and may be NULL to
		/// show the default title (&quot;Open&quot; or &quot;Save&quot; depending on the mode).
		/// |default_file_path| is the path with optional directory and/or file name
		/// component that will be initially selected in the dialog. |accept_filters|
		/// are used to restrict the selectable file types and may any combination of
		/// (a) valid lower-cased MIME types (e.g. &quot;text/*&quot; or &quot;image/*&quot;), (b)
		/// individual file extensions (e.g. &quot;.txt&quot; or &quot;.png&quot;), or (c) combined
		/// description and file extension delimited using &quot;|&quot; and &quot;;&quot; (e.g. &quot;Image
		/// Types|.png;.gif;.jpg&quot;). |callback| will be executed after the dialog is
		/// dismissed or immediately if another dialog is already pending. The dialog
		/// will be initiated asynchronously on the UI thread.
		/// </summary>
		public unsafe virtual void RunFileDialog(CefFileDialogMode mode, string title, string defaultFilePath, CefStringList acceptFilters, CefRunFileDialogCallback callback)
		{
			fixed (char* s1 = title)
			fixed (char* s2 = defaultFilePath)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = title != null ? title.Length : 0 };
				var cstr2 = new cef_string_t { Str = s2, Length = defaultFilePath != null ? defaultFilePath.Length : 0 };
				NativeInstance->RunFileDialog(mode, &cstr1, &cstr2, acceptFilters.GetNativeInstance(), (callback != null) ? callback.GetNativeInstance() : null);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Download the file at |url| using cef_download_handler_t.
		/// </summary>
		public unsafe virtual void StartDownload(string url)
		{
			fixed (char* s0 = url)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = url != null ? url.Length : 0 };
				NativeInstance->StartDownload(&cstr0);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Download |image_url| and execute |callback| on completion with the images
		/// received from the renderer. If |is_favicon| is true (1) then cookies are
		/// not sent and not accepted during download. Images with density independent
		/// pixel (DIP) sizes larger than |max_image_size| are filtered out from the
		/// image results. Versions of the image at different scale factors may be
		/// downloaded up to the maximum scale factor supported by the system. If
		/// there are no image results
		/// &lt;
		/// = |max_image_size| then the smallest image is
		/// resized to |max_image_size| and is the only result. A |max_image_size| of
		/// 0 means unlimited. If |bypass_cache| is true (1) then |image_url| is
		/// requested from the server even if it is present in the browser cache.
		/// </summary>
		public unsafe virtual void DownloadImage(string imageUrl, bool isFavicon, uint maxImageSize, bool bypassCache, CefDownloadImageCallback callback)
		{
			fixed (char* s0 = imageUrl)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = imageUrl != null ? imageUrl.Length : 0 };
				NativeInstance->DownloadImage(&cstr0, isFavicon ? 1 : 0, maxImageSize, bypassCache ? 1 : 0, (callback != null) ? callback.GetNativeInstance() : null);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Print the current browser contents.
		/// </summary>
		public unsafe virtual void Print()
		{
			NativeInstance->Print();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Print the current browser contents to the PDF file specified by |path| and
		/// execute |callback| on completion. The caller is responsible for deleting
		/// |path| when done. For PDF printing to work on Linux you must implement the
		/// cef_print_handler_t::GetPdfPaperSize function.
		/// </summary>
		public unsafe virtual void PrintToPdf(string path, CefPdfPrintSettings settings, CefPdfPrintCallback callback)
		{
			fixed (char* s0 = path)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = path != null ? path.Length : 0 };
				NativeInstance->PrintToPdf(&cstr0, (cef_pdf_print_settings_t*)&settings, (callback != null) ? callback.GetNativeInstance() : null);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Search for |searchText|. |forward| indicates whether to search forward or
		/// backward within the page. |matchCase| indicates whether the search should
		/// be case-sensitive. |findNext| indicates whether this is the first request
		/// or a follow-up. The search will be restarted if |searchText| or
		/// |matchCase| change. The search will be stopped if |searchText| is NULL.
		/// The cef_find_handler_t instance, if any, returned via
		/// cef_client_t::GetFindHandler will be called to report find results.
		/// </summary>
		public unsafe virtual void Find(string searchText, bool forward, bool matchCase, bool findNext)
		{
			fixed (char* s0 = searchText)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = searchText != null ? searchText.Length : 0 };
				NativeInstance->Find(&cstr0, forward ? 1 : 0, matchCase ? 1 : 0, findNext ? 1 : 0);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Cancel all searches that are currently going on.
		/// </summary>
		public unsafe virtual void StopFinding(bool clearSelection)
		{
			NativeInstance->StopFinding(clearSelection ? 1 : 0);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Open developer tools (DevTools) in its own browser. The DevTools browser
		/// will remain associated with this browser. If the DevTools browser is
		/// already open then it will be focused, in which case the |windowInfo|,
		/// |client| and |settings| parameters will be ignored. If
		/// |inspect_element_at| is non-NULL then the element at the specified (x,y)
		/// location will be inspected. The |windowInfo| parameter will be ignored if
		/// this browser is wrapped in a cef_browser_view_t.
		/// </summary>
		public unsafe virtual void ShowDevTools(CefWindowInfo windowInfo, CefClient client, CefBrowserSettings settings, CefPoint inspectElementAt)
		{
			NativeInstance->ShowDevTools(windowInfo.GetNativeInstance(), (client != null) ? client.GetNativeInstance() : null, settings.GetNativeInstance(), (cef_point_t*)&inspectElementAt);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Explicitly close the associated DevTools browser, if any.
		/// </summary>
		public unsafe virtual void CloseDevTools()
		{
			NativeInstance->CloseDevTools();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Send a function call message over the DevTools protocol. |message| must be
		/// a UTF8-encoded JSON dictionary that contains &quot;id&quot; (int), &quot;function&quot;
		/// (string) and &quot;params&quot; (dictionary, optional) values. See the DevTools
		/// protocol documentation at https://chromedevtools.github.io/devtools-
		/// protocol/ for details of supported functions and the expected &quot;params&quot;
		/// dictionary contents. |message| will be copied if necessary. This function
		/// will return true (1) if called on the UI thread and the message was
		/// successfully submitted for validation, otherwise false (0). Validation
		/// will be applied asynchronously and any messages that fail due to
		/// formatting errors or missing parameters may be discarded without
		/// notification. Prefer ExecuteDevToolsMethod if a more structured approach
		/// to message formatting is desired.
		/// Every valid function call will result in an asynchronous function result
		/// or error message that references the sent message &quot;id&quot;. Event messages are
		/// received while notifications are enabled (for example, between function
		/// calls for &quot;Page.enable&quot; and &quot;Page.disable&quot;). All received messages will be
		/// delivered to the observer(s) registered with AddDevToolsMessageObserver.
		/// See cef_dev_tools_message_observer_t::OnDevToolsMessage documentation for
		/// details of received message contents.
		/// Usage of the SendDevToolsMessage, ExecuteDevToolsMethod and
		/// AddDevToolsMessageObserver functions does not require an active DevTools
		/// front-end or remote-debugging session. Other active DevTools sessions will
		/// continue to function independently. However, any modification of global
		/// browser state by one session may not be reflected in the UI of other
		/// sessions.
		/// Communication with the DevTools front-end (when displayed) can be logged
		/// for development purposes by passing the `--devtools-protocol-log-
		/// file=
		/// &lt;path
		/// &gt;` command-line flag.
		/// </summary>
		public unsafe virtual bool SendDevToolsMessage(IntPtr message, long messageSize)
		{
			return SafeCall(NativeInstance->SendDevToolsMessage((void*)message, messageSize) != 0);
		}

		/// <summary>
		/// Execute a function call over the DevTools protocol. This is a more
		/// structured version of SendDevToolsMessage. |message_id| is an incremental
		/// number that uniquely identifies the message (pass 0 to have the next
		/// number assigned automatically based on previous values). |function| is the
		/// function name. |params| are the function parameters, which may be NULL.
		/// See the DevTools protocol documentation (linked above) for details of
		/// supported functions and the expected |params| dictionary contents. This
		/// function will return the assigned message ID if called on the UI thread
		/// and the message was successfully submitted for validation, otherwise 0.
		/// See the SendDevToolsMessage documentation for additional usage
		/// information.
		/// </summary>
		public unsafe virtual int ExecuteDevToolsMethod(int messageId, string method, CefDictionaryValue @params)
		{
			fixed (char* s1 = method)
			{
				var cstr1 = new cef_string_t { Str = s1, Length = method != null ? method.Length : 0 };
				return SafeCall(NativeInstance->ExecuteDevToolsMethod(messageId, &cstr1, (@params != null) ? @params.GetNativeInstance() : null));
			}
		}

		/// <summary>
		/// Add an observer for DevTools protocol messages (function results and
		/// events). The observer will remain registered until the returned
		/// Registration object is destroyed. See the SendDevToolsMessage
		/// documentation for additional usage information.
		/// </summary>
		public unsafe virtual CefRegistration AddDevToolsMessageObserver(CefDevToolsMessageObserver observer)
		{
			return SafeCall(CefRegistration.Wrap(CefRegistration.Create, NativeInstance->AddDevToolsMessageObserver((observer != null) ? observer.GetNativeInstance() : null)));
		}

		/// <summary>
		/// Retrieve a snapshot of current navigation entries as values sent to the
		/// specified visitor. If |current_only| is true (1) only the current
		/// navigation entry will be sent, otherwise all navigation entries will be
		/// sent.
		/// </summary>
		public unsafe virtual void GetNavigationEntries(CefNavigationEntryVisitor visitor, bool currentOnly)
		{
			NativeInstance->GetNavigationEntries((visitor != null) ? visitor.GetNativeInstance() : null, currentOnly ? 1 : 0);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// If a misspelled word is currently selected in an editable node calling
		/// this function will replace it with the specified |word|.
		/// </summary>
		public unsafe virtual void ReplaceMisspelling(string word)
		{
			fixed (char* s0 = word)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = word != null ? word.Length : 0 };
				NativeInstance->ReplaceMisspelling(&cstr0);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Add the specified |word| to the spelling dictionary.
		/// </summary>
		public unsafe virtual void AddWordToDictionary(string word)
		{
			fixed (char* s0 = word)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = word != null ? word.Length : 0 };
				NativeInstance->AddWordToDictionary(&cstr0);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Notify the browser that the widget has been resized. The browser will
		/// first call cef_render_handler_t::GetViewRect to get the new size and then
		/// call cef_render_handler_t::OnPaint asynchronously with the updated
		/// regions. This function is only used when window rendering is disabled.
		/// </summary>
		public unsafe virtual void WasResized()
		{
			NativeInstance->WasResized();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Notify the browser that it has been hidden or shown. Layouting and
		/// cef_render_handler_t::OnPaint notification will stop when the browser is
		/// hidden. This function is only used when window rendering is disabled.
		/// </summary>
		public unsafe virtual void WasHidden(int hidden)
		{
			NativeInstance->WasHidden(hidden);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Send a notification to the browser that the screen info has changed. The
		/// browser will then call cef_render_handler_t::GetScreenInfo to update the
		/// screen information with the new values. This simulates moving the webview
		/// window from one display to another, or changing the properties of the
		/// current display. This function is only used when window rendering is
		/// disabled.
		/// </summary>
		public unsafe virtual void NotifyScreenInfoChanged()
		{
			NativeInstance->NotifyScreenInfoChanged();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Invalidate the view. The browser will call cef_render_handler_t::OnPaint
		/// asynchronously. This function is only used when window rendering is
		/// disabled.
		/// </summary>
		public unsafe virtual void Invalidate(CefPaintElementType type)
		{
			NativeInstance->Invalidate(type);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Issue a BeginFrame request to Chromium.  Only valid when
		/// cef_window_tInfo::external_begin_frame_enabled is set to true (1).
		/// </summary>
		public unsafe virtual void SendExternalBeginFrame()
		{
			NativeInstance->SendExternalBeginFrame();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Send a key event to the browser.
		/// </summary>
		public unsafe virtual void SendKeyEvent(CefKeyEvent @event)
		{
			NativeInstance->SendKeyEvent((cef_key_event_t*)&@event);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Send a mouse click event to the browser. The |x| and |y| coordinates are
		/// relative to the upper-left corner of the view.
		/// </summary>
		public unsafe virtual void SendMouseClickEvent(CefMouseEvent @event, CefMouseButtonType type, bool mouseUp, int clickCount)
		{
			NativeInstance->SendMouseClickEvent((cef_mouse_event_t*)&@event, type, mouseUp ? 1 : 0, clickCount);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Send a mouse move event to the browser. The |x| and |y| coordinates are
		/// relative to the upper-left corner of the view.
		/// </summary>
		public unsafe virtual void SendMouseMoveEvent(CefMouseEvent @event, bool mouseLeave)
		{
			NativeInstance->SendMouseMoveEvent((cef_mouse_event_t*)&@event, mouseLeave ? 1 : 0);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Send a mouse wheel event to the browser. The |x| and |y| coordinates are
		/// relative to the upper-left corner of the view. The |deltaX| and |deltaY|
		/// values represent the movement delta in the X and Y directions
		/// respectively. In order to scroll inside select popups with window
		/// rendering disabled cef_render_handler_t::GetScreenPoint should be
		/// implemented properly.
		/// </summary>
		public unsafe virtual void SendMouseWheelEvent(CefMouseEvent @event, int deltaX, int deltaY)
		{
			NativeInstance->SendMouseWheelEvent((cef_mouse_event_t*)&@event, deltaX, deltaY);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Send a touch event to the browser for a windowless browser.
		/// </summary>
		public unsafe virtual void SendTouchEvent(CefTouchEvent @event)
		{
			NativeInstance->SendTouchEvent((cef_touch_event_t*)&@event);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Send a capture lost event to the browser.
		/// </summary>
		public unsafe virtual void SendCaptureLostEvent()
		{
			NativeInstance->SendCaptureLostEvent();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Notify the browser that the window hosting it is about to be moved or
		/// resized. This function is only used on Windows and Linux.
		/// </summary>
		public unsafe virtual void NotifyMoveOrResizeStarted()
		{
			NativeInstance->NotifyMoveOrResizeStarted();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Begins a new composition or updates the existing composition. Blink has a
		/// special node (a composition node) that allows the input function to change
		/// text without affecting other DOM nodes. |text| is the optional text that
		/// will be inserted into the composition node. |underlines| is an optional
		/// set of ranges that will be underlined in the resulting text.
		/// |replacement_range| is an optional range of the existing text that will be
		/// replaced. |selection_range| is an optional range of the resulting text
		/// that will be selected after insertion or replacement. The
		/// |replacement_range| value is only used on OS X.
		/// This function may be called multiple times as the composition changes.
		/// When the client is done making changes the composition should either be
		/// canceled or completed. To cancel the composition call
		/// ImeCancelComposition. To complete the composition call either
		/// ImeCommitText or ImeFinishComposingText. Completion is usually signaled
		/// when:
		/// 1. The client receives a WM_IME_COMPOSITION message with a GCS_RESULTSTR
		/// flag (on Windows), or;
		/// 2. The client receives a &quot;commit&quot; signal of GtkIMContext (on Linux), or;
		/// 3. insertText of NSTextInput is called (on Mac).
		/// This function is only used when window rendering is disabled.
		/// </summary>
		public unsafe virtual void ImeSetComposition(string text, long underlinesCount, CefCompositionUnderline underlines, CefRange replacementRange, CefRange selectionRange)
		{
			fixed (char* s0 = text)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = text != null ? text.Length : 0 };
				NativeInstance->ImeSetComposition(&cstr0, underlinesCount, (cef_composition_underline_t*)&underlines, (cef_range_t*)&replacementRange, (cef_range_t*)&selectionRange);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Completes the existing composition by optionally inserting the specified
		/// |text| into the composition node. |replacement_range| is an optional range
		/// of the existing text that will be replaced. |relative_cursor_pos| is where
		/// the cursor will be positioned relative to the current cursor position. See
		/// comments on ImeSetComposition for usage. The |replacement_range| and
		/// |relative_cursor_pos| values are only used on OS X. This function is only
		/// used when window rendering is disabled.
		/// </summary>
		public unsafe virtual void ImeCommitText(string text, CefRange replacementRange, int relativeCursorPos)
		{
			fixed (char* s0 = text)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = text != null ? text.Length : 0 };
				NativeInstance->ImeCommitText(&cstr0, (cef_range_t*)&replacementRange, relativeCursorPos);
			}
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Completes the existing composition by applying the current composition
		/// node contents. If |keep_selection| is false (0) the current selection, if
		/// any, will be discarded. See comments on ImeSetComposition for usage. This
		/// function is only used when window rendering is disabled.
		/// </summary>
		public unsafe virtual void ImeFinishComposingText(bool keepSelection)
		{
			NativeInstance->ImeFinishComposingText(keepSelection ? 1 : 0);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Cancels the existing composition and discards the composition node
		/// contents without applying them. See comments on ImeSetComposition for
		/// usage. This function is only used when window rendering is disabled.
		/// </summary>
		public unsafe virtual void ImeCancelComposition()
		{
			NativeInstance->ImeCancelComposition();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Call this function when the user drags the mouse into the web view (before
		/// calling DragTargetDragOver/DragTargetLeave/DragTargetDrop). |drag_data|
		/// should not contain file contents as this type of data is not allowed to be
		/// dragged into the web view. File contents can be removed using
		/// cef_drag_data_t::ResetFileContents (for example, if |drag_data| comes from
		/// cef_render_handler_t::StartDragging). This function is only used when
		/// window rendering is disabled.
		/// </summary>
		public unsafe virtual void DragTargetDragEnter(CefDragData dragData, CefMouseEvent @event, CefDragOperationsMask allowedOps)
		{
			NativeInstance->DragTargetDragEnter((dragData != null) ? dragData.GetNativeInstance() : null, (cef_mouse_event_t*)&@event, allowedOps);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Call this function each time the mouse is moved across the web view during
		/// a drag operation (after calling DragTargetDragEnter and before calling
		/// DragTargetDragLeave/DragTargetDrop). This function is only used when
		/// window rendering is disabled.
		/// </summary>
		public unsafe virtual void DragTargetDragOver(CefMouseEvent @event, CefDragOperationsMask allowedOps)
		{
			NativeInstance->DragTargetDragOver((cef_mouse_event_t*)&@event, allowedOps);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Call this function when the user drags the mouse out of the web view
		/// (after calling DragTargetDragEnter). This function is only used when
		/// window rendering is disabled.
		/// </summary>
		public unsafe virtual void DragTargetDragLeave()
		{
			NativeInstance->DragTargetDragLeave();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Call this function when the user completes the drag operation by dropping
		/// the object onto the web view (after calling DragTargetDragEnter). The
		/// object being dropped is |drag_data|, given as an argument to the previous
		/// DragTargetDragEnter call. This function is only used when window rendering
		/// is disabled.
		/// </summary>
		public unsafe virtual void DragTargetDrop(CefMouseEvent @event)
		{
			NativeInstance->DragTargetDrop((cef_mouse_event_t*)&@event);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Call this function when the drag operation started by a
		/// cef_render_handler_t::StartDragging call has ended either in a drop or by
		/// being cancelled. |x| and |y| are mouse coordinates relative to the upper-
		/// left corner of the view. If the web view is both the drag source and the
		/// drag target then all DragTarget* functions should be called before
		/// DragSource* mthods. This function is only used when window rendering is
		/// disabled.
		/// </summary>
		public unsafe virtual void DragSourceEndedAt(int x, int y, CefDragOperationsMask op)
		{
			NativeInstance->DragSourceEndedAt(x, y, op);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Call this function when the drag operation started by a
		/// cef_render_handler_t::StartDragging call has completed. This function may
		/// be called immediately without first calling DragSourceEndedAt to cancel a
		/// drag operation. If the web view is both the drag source and the drag
		/// target then all DragTarget* functions should be called before DragSource*
		/// mthods. This function is only used when window rendering is disabled.
		/// </summary>
		public unsafe virtual void DragSourceSystemDragEnded()
		{
			NativeInstance->DragSourceSystemDragEnded();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Enable notifications of auto resize via
		/// cef_display_handler_t::OnAutoResize. Notifications are disabled by
		/// default. |min_size| and |max_size| define the range of allowed sizes.
		/// </summary>
		public unsafe virtual void SetAutoResizeEnabled(int enabled, CefSize minSize, CefSize maxSize)
		{
			NativeInstance->SetAutoResizeEnabled(enabled, (cef_size_t*)&minSize, (cef_size_t*)&maxSize);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Set whether the browser is focused.
		/// </summary>
		public unsafe virtual void SetFocus(bool focus)
		{
			NativeInstance->SetFocus(focus ? 1 : 0);
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Set accessibility state for all frames. |accessibility_state| may be
		/// default, enabled or disabled. If |accessibility_state| is STATE_DEFAULT
		/// then accessibility will be disabled by default and the state may be
		/// further controlled with the &quot;force-renderer-accessibility&quot; and &quot;disable-
		/// renderer-accessibility&quot; command-line switches. If |accessibility_state| is
		/// STATE_ENABLED then accessibility will be enabled. If |accessibility_state|
		/// is STATE_DISABLED then accessibility will be completely disabled.
		/// For windowed browsers accessibility will be enabled in Complete mode
		/// (which corresponds to kAccessibilityModeComplete in Chromium). In this
		/// mode all platform accessibility objects will be created and managed by
		/// Chromium&apos;s internal implementation. The client needs only to detect the
		/// screen reader and call this function appropriately. For example, on macOS
		/// the client can handle the
		/// &quot;
		/// AXEnhancedUserStructure&quot; accessibility
		/// attribute to detect VoiceOver state changes and on Windows the client can
		/// handle WM_GETOBJECT with OBJID_CLIENT to detect accessibility readers.
		/// For windowless browsers accessibility will be enabled in TreeOnly mode
		/// (which corresponds to kAccessibilityModeWebContentsOnly in Chromium). In
		/// this mode renderer accessibility is enabled, the full tree is computed,
		/// and events are passed to CefAccessibiltyHandler, but platform
		/// accessibility objects are not created. The client may implement platform
		/// accessibility objects using CefAccessibiltyHandler callbacks if desired.
		/// </summary>
		public unsafe virtual void SetAccessibilityState(CefState accessibilityState)
		{
			NativeInstance->SetAccessibilityState(accessibilityState);
			GC.KeepAlive(this);
		}
	}
}
