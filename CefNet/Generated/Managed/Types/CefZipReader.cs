﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: Generated/Native/Types/cef_zip_reader_t.cs
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
	/// Structure that supports the reading of zip archives via the zlib unzip API.
	/// The functions of this structure should only be called on the thread that
	/// creates the object.
	/// </summary>
	/// <remarks>
	/// Role: Proxy
	/// </remarks>
	public unsafe partial class CefZipReader : CefBaseRefCounted<cef_zip_reader_t>
	{
		internal static unsafe CefZipReader Create(IntPtr instance)
		{
			return new CefZipReader((cef_zip_reader_t*)instance);
		}

		public CefZipReader(cef_zip_reader_t* instance)
			: base((cef_base_ref_counted_t*)instance)
		{
		}

		/// <summary>
		/// Gets the name of the file.
		/// The resulting string must be freed by calling cef_string_userfree_free().
		/// </summary>
		public unsafe virtual string FileName
		{
			get
			{
				return SafeCall(CefString.ReadAndFree(NativeInstance->GetFileName()));
			}
		}

		/// <summary>
		/// Gets the uncompressed size of the file.
		/// </summary>
		public unsafe virtual long FileSize
		{
			get
			{
				return SafeCall(NativeInstance->GetFileSize());
			}
		}

		/// <summary>
		/// Gets the last modified timestamp for the file.
		/// </summary>
		public unsafe virtual CefBaseTime FileLastModified
		{
			get
			{
				return SafeCall(NativeInstance->GetFileLastModified());
			}
		}

		/// <summary>
		/// Moves the cursor to the first file in the archive. Returns true (1) if the
		/// cursor position was set successfully.
		/// </summary>
		public unsafe virtual bool MoveToFirstFile()
		{
			return SafeCall(NativeInstance->MoveToFirstFile() != 0);
		}

		/// <summary>
		/// Moves the cursor to the next file in the archive. Returns true (1) if the
		/// cursor position was set successfully.
		/// </summary>
		public unsafe virtual bool MoveToNextFile()
		{
			return SafeCall(NativeInstance->MoveToNextFile() != 0);
		}

		/// <summary>
		/// Moves the cursor to the specified file in the archive. If |caseSensitive|
		/// is true (1) then the search will be case sensitive. Returns true (1) if
		/// the cursor position was set successfully.
		/// </summary>
		public unsafe virtual bool MoveToFile(string fileName, bool caseSensitive)
		{
			fixed (char* s0 = fileName)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = fileName != null ? fileName.Length : 0 };
				return SafeCall(NativeInstance->MoveToFile(&cstr0, caseSensitive ? 1 : 0) != 0);
			}
		}

		/// <summary>
		/// Closes the archive. This should be called directly to ensure that cleanup
		/// occurs on the correct thread.
		/// </summary>
		public unsafe virtual int Close()
		{
			return SafeCall(NativeInstance->Close());
		}

		/// <summary>
		/// Opens the file for reading of uncompressed data. A read password may
		/// optionally be specified.
		/// </summary>
		public unsafe virtual int OpenFile(string password)
		{
			fixed (char* s0 = password)
			{
				var cstr0 = new cef_string_t { Str = s0, Length = password != null ? password.Length : 0 };
				return SafeCall(NativeInstance->OpenFile(&cstr0));
			}
		}

		/// <summary>
		/// Closes the file.
		/// </summary>
		public unsafe virtual int CloseFile()
		{
			return SafeCall(NativeInstance->CloseFile());
		}

		/// <summary>
		/// Read uncompressed file contents into the specified buffer. Returns
		/// &lt;
		/// 0 if
		/// an error occurred, 0 if at the end of file, or the number of bytes read.
		/// </summary>
		public unsafe virtual int ReadFile(IntPtr buffer, long bufferSize)
		{
			return SafeCall(NativeInstance->ReadFile((void*)buffer, bufferSize));
		}

		/// <summary>
		/// Returns the current offset in the uncompressed file contents.
		/// </summary>
		public unsafe virtual long Tell()
		{
			return SafeCall(NativeInstance->Tell());
		}

		/// <summary>
		/// Returns true (1) if at end of the file contents.
		/// </summary>
		public unsafe virtual bool Eof()
		{
			return SafeCall(NativeInstance->Eof() != 0);
		}
	}
}
