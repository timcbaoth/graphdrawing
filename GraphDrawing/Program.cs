using System;
using Gtk;

namespace GraphDrawing
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            var win = new MainWindow(new GraphDrawingArea());
            win.Show();
            Application.Run();
        }
    }
}
