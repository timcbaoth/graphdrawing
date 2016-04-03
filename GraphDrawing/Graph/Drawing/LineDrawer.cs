using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cairo;
using GraphDrawing.Graph.Component;

namespace GraphDrawing.Graph.Drawing
{
    public class LineDrawer : ILineDrawer
    {
        public void Draw(Line line, Context context)
        {
            context.LineWidth = 9;
            context.SetSourceRGB(1, 1, 1);
            context.Translate(line.Source.Position.X, line.Source.Position.Y);
            context.LineTo(line.Target.Position);
        }
    }
}
