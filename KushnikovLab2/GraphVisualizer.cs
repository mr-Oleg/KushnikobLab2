using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KushnikovLab2
{
    public partial class GraphVisualizer : Form
    {

        private DataWrapperForDistibution wrapper;
        private int[] array;
        private string title;

        public GraphVisualizer()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            wrapper = DataWrapperForDistibution.getInstance();
            array = wrapper.getArray();
            int indexIteration;
            double graphIteration;
            for (graphIteration = 0.05 , indexIteration = 0; graphIteration <= 1 && indexIteration < 20;  graphIteration = graphIteration + 0.05, indexIteration++)
            {
                chart1.Series[0].Points.AddXY(graphIteration, array[indexIteration]);
                
            }
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 1);
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;


        }

        public void setTitle(string title)
        {
            this.title = title;
        }
    }
}
