using System;
using GraphDrawing.Graph;
using GraphDrawing.Graph.Component;
using Cairo;

namespace GraphDrawing.Graph.Drawing
{
    public interface IArcDrawer
    {
        void Draw(Arc arc, Context context);
    }
}
