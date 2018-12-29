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
    public partial class Pad : Form, IObserver
    {
        public Pad()
        {
            InitializeComponent();
        }

        public void Render(object sender, EventArgs e)
        {
            WeatherStation station = sender as WeatherStation;

            sourceNameLabel.Text = "資料來源: " + station.StationName;
            WeatherData weatherData = e as WeatherData;
            temperatureLabel.Text = string.Format("溫度: {0} 度", weatherData.Temperature.ToString("#.##"));
            humidityLabel.Text = string.Format("濕度: {0} %", weatherData.Humidity.ToString("#.##"));
        }
    }
}