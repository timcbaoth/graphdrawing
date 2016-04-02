using System;
using Cairo;

namespace GraphDrawing
{
	[System.ComponentModel.ToolboxItem (true)]
	public partial class GraphDrawingArea : Gtk.DrawingArea
	{
		public GraphDrawingArea ()
		{
		}


		public void Wahoo()
		{
			using (var cr = Gdk.CairoHelper.Create (this.GdkWindow)) 
			{

				cr.LineWidth = 9;
				cr.SetSourceRGB(0.7, 0.2, 0.0);

				int width, height;
				width = Allocation.Width;
				height = Allocation.Height;

				cr.Translate(width/2, height/2);
				cr.Arc (50, 50, 25, 0, Math.PI);
				cr.StrokePreserve();

				cr.SetSourceRGB(0.3, 0.4, 0.6);
				cr.Fill();
			}
		}
	}

}

