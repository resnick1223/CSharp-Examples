using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExtensions;

namespace Example01
{
    public class WeatherData : EventArgs
    {
        public double Temp { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        private static Random random;

        public WeatherData(double temp, double humidity, double pressure)
        {
            this.Temp = temp;
            this.Humidity = humidity;
            this.Pressure = pressure;
        }

        public override bool Equals(object obj)
        {
            if (obj is WeatherData)
            {
                WeatherData other = obj as WeatherData;
                return
                   this.Temp == other.Temp
                && this.Pressure == other.Pressure
                && this.Humidity == other.Humidity;
            }
            else
            {
                return false;
            }
        }

        public static WeatherData Generate()
        {
            if (WeatherData.random == null)
            {
                random = new Random();
            }

            double temp = random.NextDouble(15.0, 26.0);
            double pressure = random.NextDouble(0.95, 1.0);
            double humidity = random.NextDouble(80, 100);
            return new WeatherData(temp, pressure, humidity);
        }
    }
}