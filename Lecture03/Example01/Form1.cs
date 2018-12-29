using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Example01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Series series = new Series();
            DataPoint dataPoint1 = new DataPoint(5D, 5D);
            DataPoint dataPoint2 = new DataPoint(4D, 3D);
            DataPoint dataPoint3 = new DataPoint(2D, 1D);
            series.ChartArea = "ChartArea1";
            series.ChartType = SeriesChartType.Line;
            series.Legend = "Legend1";
            series.Name = "Series2";
            series.Points.Add(dataPoint1);
            series.Points.Add(dataPoint2);
            series.Points.Add(dataPoint3);
            this.chart1.Series.Add(series);
        }
    }
}