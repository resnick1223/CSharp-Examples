using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture10___Observer_Pattern
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
            WeatherStation 玉山氣象站 = new WeatherStation();
            玉山氣象站.StationName = "玉山氣象站";
            玉山氣象站.DataTimer.Interval = 500;
            WeatherStation 陽明山氣象站 = new WeatherStation();
            陽明山氣象站.StationName = "陽明山氣象站";
            陽明山氣象站.Show();
            陽明山氣象站.DataTimer.Interval = 2000;

            iPad iPadPro12 = new iPad();
            iPad iPadPro2017 = new iPad();

            玉山氣象站.Register(iPadPro12);

            陽明山氣象站.Register(iPadPro12);
            陽明山氣象站.Register(iPadPro2017);

            Application.Run(玉山氣象站);
        }
    }
}