using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Example01;

namespace Example02
{
    public partial class WeatherStation : Form, IObserverable, IObserver
    {
        private WeatherData data;
        private List<IObserver> observers;
        public string StationName { get; set; }

        public WeatherStation()
        {
            InitializeComponent();
            data = WeatherData.Generate();
            observers = new List<IObserver>();
            observers.Add(this);
            UpdateView(this, data);
        }

        public void Notify()
        {
            foreach (IObserver o in observers)
                o.UpdateView(this, this.data);
        }

        public void Register(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void UpdateView(object sender, EventArgs e)
        {
            this.tempTextBox.Text = this.data.Temp.ToString();
            this.pressureTextBox.Text = this.data.Pressure.ToString();
            this.humidyTextBox.Text = this.data.Humidity.ToString();
        }

        private void dataTimer_Tick(object sender, EventArgs e)
        {
            WeatherData other = WeatherData.Generate();
            OnMessurementsChanged(this, other);
        }

        private void OnMessurementsChanged(object sender, EventArgs e)
        {
            WeatherData other = e as WeatherData;
            if (!this.data.Equals(other))
            {
                this.data = other;
                Notify();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.dataTimer.Enabled = !this.dataTimer.Enabled;

            this.startButton.Text = this.dataTimer.Enabled ? "Pause" : "Start";
        }

        private void tempLabel_Click(object sender, EventArgs e)
        {
        }

        private void pressureLabel_Click(object sender, EventArgs e)
        {
        }

        private void tempTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}