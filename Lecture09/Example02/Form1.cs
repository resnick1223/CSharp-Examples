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
using EasyMath;

namespace Example02
{
    public partial class Form1 : Form
    {
        private int currentTime = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateDataPointsButton_Click(object sender, EventArgs e)
        {
            this.chart1.Series.Clear();
            this.chart1.Series.Add(Vector.GenerateSeries(20, -100, 100));
        }

        private void DataTimer_Tick(object sender, EventArgs e)
        {
            EasyRandom random = new EasyRandom();

            double x = currentTime + random.NextDouble(-21, 21);
            double y = random.NextDouble(-21, 21);
            DataPoint dataPoint = new DataPoint(x, y);
            this.chart1.Series[0].Points.Add(dataPoint);
            currentTime += DataTimer.Interval;
        }
    }
}