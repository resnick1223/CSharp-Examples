using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternExample
{
    public partial class AppleWatch : Form, IObserver
    {
        public AppleWatch()
        {
            InitializeComponent();
        }

        public void Render(object sender, EventArgs e)
        {
            WeatherData weatherData = e as WeatherData;
            this.temperatureLabel.Text = string.Format("溫度: {0} 度", weatherData.Temperature.ToString("#.##"));
        }
    }
}