using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace GViewerBugReport
{
    /// <summary>
    /// Interaction logic for GViewerToolWindowControl.
    /// </summary>
    public partial class GViewerToolWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GViewerToolWindowControl"/> class.
        /// </summary>
        public GViewerToolWindowControl()
        {
            InitializeComponent();
            var graph = CreateGraph();
            var gViewer = new GViewer {Graph = graph};
            Wfh.Child = gViewer;
        }



        private Graph CreateGraph()
        {
            Graph graph = new Graph("graph");
            //create the graph content 
            graph.AddEdge("A", "B");
            graph.AddEdge("B", "C");
            graph.AddEdge("A", "C").Attr.Color = Color.Green;
            graph.FindNode("A").Attr.FillColor = Color.Magenta;
            graph.FindNode("B").Attr.FillColor = Color.MistyRose;
            Node c = graph.FindNode("C");
            c.Attr.FillColor = Color.PaleGreen;
            c.Attr.Shape = Shape.Diamond;
            return graph;
        }
    }
}