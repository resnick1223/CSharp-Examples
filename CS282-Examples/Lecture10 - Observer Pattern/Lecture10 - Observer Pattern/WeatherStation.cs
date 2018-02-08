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
    public partial class WeatherStation : Form, IObservable, IObserver
    {
        private List<IObserver> observers;

        private WeatherData data;

        public string StationName { get; set; }

        public WeatherStation()
        {
            InitializeComponent();
            observers = new List<IObserver>();
            Register(this);
        }

        public void Render(object sender, EventArgs e)
        {
            WeatherData data = e as WeatherData;

            this.StationNameLabel.Text = this.StationName;
            this.TemperatureLabel.Text = "攝氏: " + data.Temperature.ToString("#.##") + " 度";
            this.HumidityLabel.Text = "濕度: " + (data.Humidity).ToString("#.##") + "%";
            this.PressureLabel.Text = "氣壓: " + data.Pressure.ToString("#.##");
            this.TimeLabel.Text = "更新時間:" + data.Time.ToString();
        }

        private void DataTimer_Tick(object sender, EventArgs e)
        {
            WeatherData other = WeatherData.Generate();

            OnMeasurementsChanged(other);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.DataTimer.Enabled = !this.DataTimer.Enabled;
        }

        private void WeatherStation_Load(object sender, EventArgs e)
        {
            this.data = WeatherData.Generate();
            Render(this, data);
        }

        public void Register(IObserver o)
        {
            observers.Add(o);
            if (o is Form)
            {
                (o as Form).Show();
            }
        }

        public void Remove(IObserver o)
        {
            observers.Remove(o);
        }

        public void OnMeasurementsChanged(WeatherData other)
        {
            if (!this.data.Equals(other))
            {
                this.data = other;
                Notify();
            }
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
                o.Render(this, data);
        }
    }
}