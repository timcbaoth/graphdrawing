using System;
using GraphDrawing.Graph;
using GraphDrawing.Graph.Component;
using Cairo;

namespace GraphDrawing.Graph.Drawing
{
    public interface ILineDrawer
    {
        void Draw(Line line, Context context);
    }
}
