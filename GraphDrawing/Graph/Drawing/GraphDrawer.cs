﻿using System;
using GraphDrawing.Graph;
using GraphDrawing.Graph.Component;
using Cairo;
using Gdk;

namespace GraphDrawing.Graph.Drawing
{
	public class GraphDrawer
	{
		private readonly Window gdkWindow;
		private readonly INodeDrawer nodeDrawer;
		private readonly IArcDrawer arcDrawer;
		private readonly ILineDrawer lineDrawer;

		public GraphDrawer (Window gdkWindow, INodeDrawer nodeDrawer, IArcDrawer arcDrawer, ILineDrawer lineDrawer)
		{
			this.gdkWindow = gdkWindow;
			this.nodeDrawer = nodeDrawer;
			this.arcDrawer = arcDrawer;
			this.lineDrawer = lineDrawer;
		}

		public void Draw(Graph graph)
		{
			using (var context = Gdk.CairoHelper.Create(gdkWindow)) 
			{
				foreach (var node in graph.Nodes) 
				{
					nodeDrawer.Draw(node);
				}

				foreach (var arc in graph.Arcs) 
				{
					arcDrawer.Draw(arc);
				}

				foreach (var line in graph.Lines) 
				{
					lineDrawer.Draw(line);
				}
			}
		}			
	}
}
