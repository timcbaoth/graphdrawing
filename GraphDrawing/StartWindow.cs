using Gtk;
using Mono.Unix;

namespace GraphDrawing
{
    public class StartWindow : Window
    {
        public StartWindow() : base(WindowType.Toplevel)
        {
            Name = "GraphDrawing.MainWindow";
            Title = Catalog.GetString("Graph drawing");
            WindowPosition = ((WindowPosition)(4));
            Child?.ShowAll();
            DefaultWidth = 400;
            DefaultHeight = 300;

            var fileChooser = new FileChooserWidget();
            Show();
            DeleteEvent += OnDeleteEvent;
            ShowAll();
        }       

        protected void OnDeleteEvent(object sender, DeleteEventArgs a)
        {
            Application.Quit();
            a.RetVal = true;
        }
    }
}