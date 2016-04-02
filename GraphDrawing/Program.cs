using System;
using Gtk;

namespace GraphDrawing
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow(new GraphDrawingArea());
            win.Show();
            Application.Run();
        }
    }
}
