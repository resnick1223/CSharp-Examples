using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath;

namespace ObserverPatternExample
{
    public class WeatherData : EventArgs
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public double Pressure { get; set; }
        private static Random random;

        public static WeatherData Generate()
        {
            if (random == null)
                random = new Random();
            return new WeatherData()
            {
                Temperature = random.NextDouble(27.0, 33.0),
                Humidity = random.NextDouble(90, 100),
                Pressure = random.NextDouble(0.98, 1.02)
            };
        }

        public override bool Equals(object obj)
        {
            if (obj is WeatherData)
            {
                WeatherData other = obj as WeatherData;
                return
                    this.Temperature == other.Temperature &&
                    this.Humidity == other.Humidity &&
                    this.Pressure == other.Pressure;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}