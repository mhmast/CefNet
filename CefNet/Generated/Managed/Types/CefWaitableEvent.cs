﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_waitable_event_t.cs
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
	/// WaitableEvent is a thread synchronization tool that allows one thread to
	/// wait for another thread to finish some work. This is equivalent to using a
	/// Lock+ConditionVariable to protect a simple boolean value. However, using
	/// WaitableEvent in conjunction with a Lock to wait for a more complex state
	/// change (e.g., for an item to be added to a queue) is not recommended. In
	/// that case consider using a ConditionVariable instead of a WaitableEvent. It
	/// is safe to create and/or signal a WaitableEvent from any thread. Blocking on
	/// a WaitableEvent by calling the *wait() functions is not allowed on the
	/// browser process UI or IO threads.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefWaitableEvent : CefBaseRefCounted<cef_waitable_event_t>
	{
		internal static unsafe CefWaitableEvent Create(IntPtr instance)
		{
			return new CefWaitableEvent((cef_waitable_event_t*)instance);
		}

		public CefWaitableEvent(cef_waitable_event_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets a value indicating whether the event is in the signaled state, else false. If
		/// the event was created with |automatic_reset| set to true then calling
		/// this property will also cause a reset.
		/// </summary>
		public unsafe virtual bool IsSignaled
		{
			get
			{
				return SafeCall(NativeInstance->IsSignaled() != 0);
			}
		}

		/// <summary>
		/// Put the event in the un-signaled state.
		/// </summary>
		public unsafe virtual void Reset()
		{
			NativeInstance->Reset();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Put the event in the signaled state. This causes any thread blocked on
		/// Wait to be woken up.
		/// </summary>
		public unsafe virtual void Signal()
		{
			NativeInstance->Signal();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Wait indefinitely for the event to be signaled. This function will not
		/// return until after the call to signal() has completed. This function
		/// cannot be called on the browser process UI or IO threads.
		/// </summary>
		public unsafe virtual void Wait()
		{
			NativeInstance->Wait();
			GC.KeepAlive(this);
		}

		/// <summary>
		/// Wait up to |max_ms| milliseconds for the event to be signaled. Returns
		/// true (1) if the event was signaled. A return value of false (0) does not
		/// necessarily mean that |max_ms| was exceeded. This function will not return
		/// until after the call to signal() has completed. This function cannot be
		/// called on the browser process UI or IO threads.
		/// </summary>
		public unsafe virtual bool TimedWait(long maxMs)
		{
			return SafeCall(NativeInstance->TimedWait(maxMs) != 0);
		}
	}
}
