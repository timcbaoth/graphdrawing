using System;
using System.ComponentModel;
using Cairo;
using Gdk;
using GraphDrawing.Graph.Drawing;
using Gtk;
using Rectangle = Cairo.Rectangle;

namespace GraphDrawing
{
    public class GraphDrawingArea : DrawingArea
    {
        public void Wahoo()
        {

            using (var cr = CairoHelper.Create(GdkWindow))
            {

                cr.LineWidth = 9;
                cr.SetSourceRGB(0.7, 0.2, 0.0);

                cr.Arc(50, 50, 25, 0, Math.PI);

                cr.Rectangle(new Rectangle(90, 90, 70, 50));
                cr.StrokePreserve();

                cr.SetSourceRGB(0.3, 0.4, 0.6);
                cr.Fill();
            }
        }
    }

}

