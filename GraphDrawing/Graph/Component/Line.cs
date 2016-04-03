namespace GraphDrawing.Graph.Component
{
    public class Line
    {
        public Node Source { get; }
        public Node Target { get; }

        public Line(Node source, Node target)
        {
            Source = source;
            Target = target;
        }
    }
}

