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
        private AppleWatch appleWatch2;
        private AppleWatch appleWatch3;

        public WeatherStation()
        {
            InitializeComponent();
            appleWatch2 = new AppleWatch();
            appleWatch2.Show();
            appleWatch3 = new AppleWatch();
            appleWatch3.Show();
            weatherData = WeatherData.Generate();
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            weatherData = WeatherData.Generate();
            Render();
        }

        public void Render()
        {
            temperatureLabel.Text = string.Format("溫度: {0} 度", weatherData.Temperature.ToString("#.##"));
            humidityLabel.Text = string.Format("濕度: {0} %", weatherData.Humidity.ToString("#.##"));
            pressureLabel.Text = string.Format("壓力: {0} 大氣壓", weatherData.Pressure.ToString("#.##"));
            startButton.Text = dataTimer.Enabled ? "停止" : "接收資料";
            appleWatch2.temperatureLabel.Text = temperatureLabel.Text;
            appleWatch3.temperatureLabel.Text = temperatureLabel.Text;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            dataTimer.Enabled = !dataTimer.Enabled;
            Render();
        }
    }
}