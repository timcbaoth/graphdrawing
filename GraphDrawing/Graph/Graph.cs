using GraphDrawing.Graph.Component;
using GraphDrawing.Collections;

namespace GraphDrawing.Graph
{
    public class Graph
    {
        public IReadOnlySet<Node> Nodes { get; }
        public IReadOnlySet<Arc> Arcs { get; }
        public IReadOnlySet<Line> Lines { get; }

        public int NumberOfNodes => Nodes.Count;
        public int NumberOfLines => Lines.Count;
        public int NumberOfArcs => Arcs.Count;
        public int NumberOfConnections => NumberOfArcs + NumberOfLines;

        public Graph(IReadOnlySet<Node> nodes, IReadOnlySet<Arc> arcs, IReadOnlySet<Line> lines)
        {
            Nodes = nodes;
            Arcs = arcs;
            Lines = lines;
        }
    }
}

