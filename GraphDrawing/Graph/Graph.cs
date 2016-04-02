using System;
using GraphDrawing.Graph.Component;
using System.Collections.Generic;

namespace GraphDrawing.Graph
{
	public class Graph
	{
		public ISet<Node> Nodes { get; }
		public ISet<Arc> Arcs { get; }
		public ISet<Line> Lines { get; }

		public Graph (ISet<Node> nodes, ISet<Arc> arcs, ISet<Line> lines)
		{
			Nodes = nodes;
			Arcs = arcs;
			Lines = lines;
		}
	}
}

