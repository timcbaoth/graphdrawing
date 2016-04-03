using Gtk;
using Mono.Unix;

namespace GraphDrawing
{
    public class MainWindow : Window
    {
        private readonly GraphDrawingArea graphDrawingArea;

        public MainWindow(GraphDrawingArea graphDrawingArea) : base(WindowType.Toplevel)
        {
            Name = "GraphDrawing.MainWindow";
            Title = Catalog.GetString("Graph drawing");
            WindowPosition = ((WindowPosition)(4));
            Child?.ShowAll();
            DefaultWidth = 400;
            DefaultHeight = 300;
            Show();
            DeleteEvent += OnDeleteEvent;
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

        private void OnExpose(object sender, ExposeEventArgs args)
        {
            graphDrawingArea.Wahoo();
        }
    }
}