using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cairo;
using GraphDrawing.Graph.Component;

namespace GraphDrawing.Graph.Drawing
{
    public class NodeDrawer : INodeDrawer
    {
        public NodeDrawer()
        {

        }

        public void Draw(Node node, Context context)
        {
            context.LineWidth = 9;
            context.SetSourceRGB(1, 1, 1);
            context.Arc(node.Position.X, node.Position.Y, 5, 0, 2 * Math.PI);
            context.Fill();
        }
    }
}
