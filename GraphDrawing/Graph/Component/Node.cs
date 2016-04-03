using Cairo;

namespace GraphDrawing.Graph.Component
{
    public class Node
    {
        public PointD Position { get; }

        public Node(PointD position)
        {
            Position = position;
        }
    }
}

