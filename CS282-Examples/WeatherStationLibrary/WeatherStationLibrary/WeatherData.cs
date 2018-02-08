using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace WeatherStationLibrary
{
    public class WeatherData : EventArgs
    {
        private double temperature;
        private double humidity;
        private double pressure;
        private static Random random;
        public DateTime Time;

        public double Temperature
        {
            get
            {
                return this.temperature;
            }

            set
            {
                if (value > 40)
                {
                    this.temperature = 40;
                }
                else if (value < -10)
                {
                    this.temperature = -10;
                }
                else
                {
                    this.temperature = value;
                }
            }
        }

        public double Humidity
        {
            get => humidity;
            set => humidity = value;
        }

        public double Pressure { get => pressure; set => pressure = value; }

        public bool Equals(WeatherData other)
        {
            return this.Temperature == other.Temperature
                   && this.Humidity == other.Humidity
                   && this.Pressure == other.Pressure;
        }

        public static WeatherData Generate()
        {
            if (random == null)
                random = new Random();

            return new WeatherData()
            {
                Temperature = random.NextDouble(25.0, 33.0),
                Humidity = random.NextDouble(80, 100),
                Pressure = random.NextDouble(0.99, 1.0),
                Time = new DateTime()
            };
        }
    }
}