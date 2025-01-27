﻿// --------------------------------------------------------------------------------------------
// Copyright (c) 2019 The CefNet Authors. All rights reserved.
// Licensed under the MIT license.
// See the licence file in the project root for full license information.
// --------------------------------------------------------------------------------------------
// Generated by CefGen
// Source: include/capi/cef_image_capi.h
// --------------------------------------------------------------------------------------------﻿
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
// --------------------------------------------------------------------------------------------

#pragma warning disable 0169, 1591, 1573

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using CefNet.WinApi;

namespace CefNet.CApi
{
	/// <summary>
	/// Container for a single image represented at different scale factors. All
	/// image representations should be the same size in density independent pixel
	/// (DIP) units. For example, if the image at scale factor 1.0 is 100x100 pixels
	/// then the image at scale factor 2.0 should be 200x200 pixels -- both images
	/// will display with a DIP size of 100x100 units. The functions of this
	/// structure can be called on any browser process thread.
	/// </summary>
	[StructLayout(LayoutKind.Sequential)]
	public unsafe partial struct cef_image_t
	{
		/// <summary>
		/// Base structure.
		/// </summary>
		public cef_base_ref_counted_t @base;

		/// <summary>
		/// int (*)(_cef_image_t* self)*
		/// </summary>
		public void* is_empty;

		/// <summary>
		/// Returns true (1) if this Image is NULL.
		/// </summary>
		[NativeName("is_empty")]
		public unsafe int IsEmpty()
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, int>)is_empty)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_image_t* self, _cef_image_t* that)*
		/// </summary>
		public void* is_same;

		/// <summary>
		/// Returns true (1) if this Image and |that| Image share the same underlying
		/// storage. Will also return true (1) if both images are NULL.
		/// </summary>
		[NativeName("is_same")]
		public unsafe int IsSame(cef_image_t* that)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, cef_image_t*, int>)is_same)(self, that);
			}
		}

		/// <summary>
		/// int (*)(_cef_image_t* self, float scale_factor, int pixel_width, int pixel_height, cef_color_type_t color_type, cef_alpha_type_t alpha_type, const void* pixel_data, size_t pixel_data_size)*
		/// </summary>
		public void* add_bitmap;

		/// <summary>
		/// Add a bitmap image representation for |scale_factor|. Only 32-bit
		/// RGBA/BGRA formats are supported. |pixel_width| and |pixel_height| are the
		/// bitmap representation size in pixel coordinates. |pixel_data| is the array
		/// of pixel data and should be |pixel_width| x |pixel_height| x 4 bytes in
		/// size. |color_type| and |alpha_type| values specify the pixel format.
		/// </summary>
		[NativeName("add_bitmap")]
		public unsafe int AddBitmap(float scale_factor, int pixel_width, int pixel_height, CefColorType color_type, CefAlphaType alpha_type, [Immutable]void* pixel_data, UIntPtr pixel_data_size)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, int, int, CefColorType, CefAlphaType, void*, UIntPtr, int>)add_bitmap)(self, scale_factor, pixel_width, pixel_height, color_type, alpha_type, pixel_data, pixel_data_size);
			}
		}

		/// <summary>
		/// int (*)(_cef_image_t* self, float scale_factor, const void* png_data, size_t png_data_size)*
		/// </summary>
		public void* add_png;

		/// <summary>
		/// Add a PNG image representation for |scale_factor|. |png_data| is the image
		/// data of size |png_data_size|. Any alpha transparency in the PNG data will
		/// be maintained.
		/// </summary>
		[NativeName("add_png")]
		public unsafe int AddPng(float scale_factor, [Immutable]void* png_data, UIntPtr png_data_size)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, void*, UIntPtr, int>)add_png)(self, scale_factor, png_data, png_data_size);
			}
		}

		/// <summary>
		/// int (*)(_cef_image_t* self, float scale_factor, const void* jpeg_data, size_t jpeg_data_size)*
		/// </summary>
		public void* add_jpeg;

		/// <summary>
		/// Create a JPEG image representation for |scale_factor|. |jpeg_data| is the
		/// image data of size |jpeg_data_size|. The JPEG format does not support
		/// transparency so the alpha byte will be set to 0xFF for all pixels.
		/// </summary>
		[NativeName("add_jpeg")]
		public unsafe int AddJpeg(float scale_factor, [Immutable]void* jpeg_data, UIntPtr jpeg_data_size)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, void*, UIntPtr, int>)add_jpeg)(self, scale_factor, jpeg_data, jpeg_data_size);
			}
		}

		/// <summary>
		/// size_t (*)(_cef_image_t* self)*
		/// </summary>
		public void* get_width;

		/// <summary>
		/// Returns the image width in density independent pixel (DIP) units.
		/// </summary>
		[NativeName("get_width")]
		public unsafe UIntPtr GetWidth()
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, UIntPtr>)get_width)(self);
			}
		}

		/// <summary>
		/// size_t (*)(_cef_image_t* self)*
		/// </summary>
		public void* get_height;

		/// <summary>
		/// Returns the image height in density independent pixel (DIP) units.
		/// </summary>
		[NativeName("get_height")]
		public unsafe UIntPtr GetHeight()
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, UIntPtr>)get_height)(self);
			}
		}

		/// <summary>
		/// int (*)(_cef_image_t* self, float scale_factor)*
		/// </summary>
		public void* has_representation;

		/// <summary>
		/// Returns true (1) if this image contains a representation for
		/// |scale_factor|.
		/// </summary>
		[NativeName("has_representation")]
		public unsafe int HasRepresentation(float scale_factor)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, int>)has_representation)(self, scale_factor);
			}
		}

		/// <summary>
		/// int (*)(_cef_image_t* self, float scale_factor)*
		/// </summary>
		public void* remove_representation;

		/// <summary>
		/// Removes the representation for |scale_factor|. Returns true (1) on
		/// success.
		/// </summary>
		[NativeName("remove_representation")]
		public unsafe int RemoveRepresentation(float scale_factor)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, int>)remove_representation)(self, scale_factor);
			}
		}

		/// <summary>
		/// int (*)(_cef_image_t* self, float scale_factor, float* actual_scale_factor, int* pixel_width, int* pixel_height)*
		/// </summary>
		public void* get_representation_info;

		/// <summary>
		/// Returns information for the representation that most closely matches
		/// |scale_factor|. |actual_scale_factor| is the actual scale factor for the
		/// representation. |pixel_width| and |pixel_height| are the representation
		/// size in pixel coordinates. Returns true (1) on success.
		/// </summary>
		[NativeName("get_representation_info")]
		public unsafe int GetRepresentationInfo(float scale_factor, float* actual_scale_factor, int* pixel_width, int* pixel_height)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, float*, int*, int*, int>)get_representation_info)(self, scale_factor, actual_scale_factor, pixel_width, pixel_height);
			}
		}

		/// <summary>
		/// _cef_binary_value_t* (*)(_cef_image_t* self, float scale_factor, cef_color_type_t color_type, cef_alpha_type_t alpha_type, int* pixel_width, int* pixel_height)*
		/// </summary>
		public void* get_as_bitmap;

		/// <summary>
		/// Returns the bitmap representation that most closely matches
		/// |scale_factor|. Only 32-bit RGBA/BGRA formats are supported. |color_type|
		/// and |alpha_type| values specify the desired output pixel format.
		/// |pixel_width| and |pixel_height| are the output representation size in
		/// pixel coordinates. Returns a cef_binary_value_t containing the pixel data
		/// on success or NULL on failure.
		/// </summary>
		[NativeName("get_as_bitmap")]
		public unsafe cef_binary_value_t* GetAsBitmap(float scale_factor, CefColorType color_type, CefAlphaType alpha_type, int* pixel_width, int* pixel_height)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, CefColorType, CefAlphaType, int*, int*, cef_binary_value_t*>)get_as_bitmap)(self, scale_factor, color_type, alpha_type, pixel_width, pixel_height);
			}
		}

		/// <summary>
		/// _cef_binary_value_t* (*)(_cef_image_t* self, float scale_factor, int with_transparency, int* pixel_width, int* pixel_height)*
		/// </summary>
		public void* get_as_png;

		/// <summary>
		/// Returns the PNG representation that most closely matches |scale_factor|.
		/// If |with_transparency| is true (1) any alpha transparency in the image
		/// will be represented in the resulting PNG data. |pixel_width| and
		/// |pixel_height| are the output representation size in pixel coordinates.
		/// Returns a cef_binary_value_t containing the PNG image data on success or
		/// NULL on failure.
		/// </summary>
		[NativeName("get_as_png")]
		public unsafe cef_binary_value_t* GetAsPng(float scale_factor, int with_transparency, int* pixel_width, int* pixel_height)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, int, int*, int*, cef_binary_value_t*>)get_as_png)(self, scale_factor, with_transparency, pixel_width, pixel_height);
			}
		}

		/// <summary>
		/// _cef_binary_value_t* (*)(_cef_image_t* self, float scale_factor, int quality, int* pixel_width, int* pixel_height)*
		/// </summary>
		public void* get_as_jpeg;

		/// <summary>
		/// Returns the JPEG representation that most closely matches |scale_factor|.
		/// |quality| determines the compression level with 0 == lowest and 100 ==
		/// highest. The JPEG format does not support alpha transparency and the alpha
		/// channel, if any, will be discarded. |pixel_width| and |pixel_height| are
		/// the output representation size in pixel coordinates. Returns a
		/// cef_binary_value_t containing the JPEG image data on success or NULL on
		/// failure.
		/// </summary>
		[NativeName("get_as_jpeg")]
		public unsafe cef_binary_value_t* GetAsJpeg(float scale_factor, int quality, int* pixel_width, int* pixel_height)
		{
			fixed (cef_image_t* self = &this)
			{
				return ((delegate* unmanaged[Stdcall]<cef_image_t*, float, int, int*, int*, cef_binary_value_t*>)get_as_jpeg)(self, scale_factor, quality, pixel_width, pixel_height);
			}
		}
	}
}

