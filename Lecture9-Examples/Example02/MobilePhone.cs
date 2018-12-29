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
    public partial class MobilePhone : Form, IObserver
    {
        public MobilePhone()
        {
            InitializeComponent();
        }

        public void UpdateView(object sender, EventArgs e)
        {
            WeatherData data = e as WeatherData;
            this.tempTextBox.Text = data.Temp.ToString();
            this.pressureTextBox.Text = data.Pressure.ToString();
            WeatherStation station = sender as WeatherStation;
            dataSourceLabel.Text = "資料來源:" + station.StationName;
        }
    }
}