using System;
using Gtk;

namespace GraphDrawing
{
	public partial class MainWindow: Gtk.Window
	{
		private readonly GraphDrawingArea graphDrawingArea;

		public MainWindow (GraphDrawingArea graphDrawingArea) : base (Gtk.WindowType.Toplevel)
		{
			Build ();
			this.graphDrawingArea = graphDrawingArea;
			this.Add (graphDrawingArea);
			graphDrawingArea.ExposeEvent += OnExpose;
			this.graphDrawingArea.Wahoo ();
			ShowAll ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}

		void OnExpose(object sender, ExposeEventArgs args)
		{
			graphDrawingArea.Wahoo ();
		}
	}
}