using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherStationLibrary;

namespace Lecture10___Observer_Pattern
{
    public partial class iPad : Form, IObserver
    {
        public iPad()
        {
            InitializeComponent();
        }

        public void Render(object sender, EventArgs e)
        {
            WeatherData data = e as WeatherData;
            WeatherStation station = sender as WeatherStation;
            this.StationNameLabel.Text = "資料來源: " + station.StationName;
            this.TemperatureLabel.Text = "攝氏: " + data.Temperature.ToString("#.##") + " 度";
            this.HumidityLabel.Text = "濕度: " + (data.Humidity).ToString("#.##") + "%";
            this.PressureLabel.Text = "氣壓: " + data.Pressure.ToString("#.##");
            this.TimeLabel.Text = "更新時間:" + data.Time.ToString();
        }
    }
}