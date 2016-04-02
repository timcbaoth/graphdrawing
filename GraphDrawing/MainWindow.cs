using System;
using Gtk;

namespace GraphDrawing
{
    public class MainWindow : Window
    {
        private readonly GraphDrawingArea graphDrawingArea;

        public MainWindow(GraphDrawingArea graphDrawingArea) : base(WindowType.Toplevel)
        {
            Name = "GraphDrawing.MainWindow";
            Title = Mono.Unix.Catalog.GetString("Graph drawing");
            WindowPosition = ((WindowPosition)(4));
            if ((Child != null))
            {
                Child.ShowAll();
            }
            DefaultWidth = 400;
            DefaultHeight = 300;
            Show();
            DeleteEvent += new DeleteEventHandler(this.OnDeleteEvent);
            this.graphDrawingArea = graphDrawingArea;
            Add(graphDrawingArea);
            graphDrawingArea.ExposeEvent += OnExpose;
            this.graphDrawingArea.Wahoo();
            ShowAll();
        }       

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }

        void OnExpose(object sender, ExposeEventArgs args)
        {
            graphDrawingArea.Wahoo();
        }
    }
}