using Avalonia;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using CefNet.Internal;

namespace CefNet.Avalonia
{
	public sealed class CustomCursor
	{
		public unsafe static Cursor Create(ref CefCursorInfo cursorInfo)
		{
			CefSize size = cursorInfo.Size;
			CefPoint hotSpot = cursorInfo.Hotspot;
			using (var bitmap = new Bitmap(PixelFormat.Bgra8888, AlphaFormat.Premul, cursorInfo.Buffer,
				new PixelSize(size.Width, size.Height), OffscreenGraphics.DpiScale.Dpi, size.Width * 4))
			{
				return new Cursor(bitmap, new PixelPoint(hotSpot.X, hotSpot.Y));
			}
		}
	}
}
