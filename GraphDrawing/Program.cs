using System;
using System.IO;
using System.Linq;
using Cairo;
using GraphDrawing.Graph.Component;
using GraphDrawing.Graph.Drawing;
using Gtk;

namespace GraphDrawing
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            var graphDrawingArea = new GraphDrawingArea();
            var win = new MainWindow(graphDrawingArea);
            var drawer = new GraphDrawer(graphDrawingArea.GdkWindow, new NodeDrawer(), new ArcDrawer(), new LineDrawer());
            var graph = GetGraph(args.FirstOrDefault());
            drawer.Draw(graph);

            win.Show();
            Application.Run();
        }

        private static Graph.Graph GetGraph(string filePath)
        {
            throw new NotImplementedException();
        }
    }

}
