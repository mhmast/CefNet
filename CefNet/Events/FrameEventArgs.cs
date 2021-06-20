using System;
using System.Collections.Generic;
using System.Text;

namespace CefNet
{
	/// <summary>
	/// Provides data for a frame event.
	/// </summary>
	public class FrameEventArgs : EventArgs
	{
		public FrameEventArgs(CefFrame frame)
		{
			this.Frame = frame;
		}

		/// <summary>
		/// The frame.
		/// </summary>
		public CefFrame Frame { get; }
	}
}
