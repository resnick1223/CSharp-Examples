using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ObserverPatternExample
{
    internal static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            WeatherStation station1 = new WeatherStation()
            {
                StationName = "陽明山觀測站",
                UpdateInterval = 500
            };

            WeatherStation station2 = new WeatherStation()
            {
                StationName = "玉山觀測站",
                UpdateInterval = 2000
            };
            station2.Show();
            Pad iPad = new Pad();
            iPad.Show();
            station1.Register(iPad);
            station2.Register(iPad);

            Application.Run(station1);
        }
    }
}