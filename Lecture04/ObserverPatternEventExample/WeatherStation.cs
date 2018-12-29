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
    public partial class WeatherStation : Form
    {
        private WeatherData weatherData;
        public string StationName { get; set; }

        public event EventHandler WeatherDataChanged;

        public WeatherStation()
        {
            InitializeComponent();
            weatherData = WeatherData.Generate();
            Render(this, weatherData);
            WeatherDataChanged += this.Render;
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            OnWeatherDataChanged(WeatherData.Generate());
        }

        public int UpdateInterval
        {
            get
            {
                return dataTimer.Interval;
            }

            set
            {
                dataTimer.Interval = value >= 500 ? value : 500;
            }
        }

        public void Render(object sender, EventArgs e)
        {
            temperatureLabel.Text = string.Format("溫度: {0} 度", weatherData.Temperature.ToString("#.##"));
            humidityLabel.Text = string.Format("濕度: {0} %", weatherData.Humidity.ToString("#.##"));
            pressureLabel.Text = string.Format("壓力: {0} 大氣壓", weatherData.Pressure.ToString("#.##"));
            startButton.Text = dataTimer.Enabled ? "停止" : "接收資料";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            dataTimer.Enabled = !dataTimer.Enabled;
            Render(this, this.weatherData);
        }

        private void OnWeatherDataChanged(WeatherData newWeatherData)
        {
            if (!this.weatherData.Equals(newWeatherData))
            {
                this.weatherData = newWeatherData;
                WeatherDataChanged(this, weatherData);
            }
        }

        private void WeatherStation_Load(object sender, EventArgs e)
        {
            stationNameLabel.Text = StationName;
        }
    }
}