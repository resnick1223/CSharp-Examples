using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
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
            WeatherStation station1 = new WeatherStation();
            station1.StationName = "陽明山氣象站";
            station1.dataTimer.Interval = 200;
            WeatherStation station2 = new WeatherStation();
            station2.StationName = "玉山氣象站";
            station2.dataTimer.Interval = 1100;

            MobilePhone iPhone = new MobilePhone();

            station1.Register(iPhone);
            station2.Register(iPhone);
            station1.Show();
            station2.Show();
            iPhone.Show();
            Application.Run(station1);
        }
    }
}