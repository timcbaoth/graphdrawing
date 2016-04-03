namespace GraphDrawing.Graph.Component
{
    public class Arc
    {
        public Node Source { get; }
        public Node Target { get; }
        public double Radius { get; }

        public Arc(Node source, Node target, double radius)
        {
            Source = source;
            Target = target;
            Radius = radius;
        }
    }
}

