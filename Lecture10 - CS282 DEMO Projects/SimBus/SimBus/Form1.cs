using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using EasyMathLibrary;

namespace SimBus
{
    public partial class Form1 : Form
    {
        public int rand = 0;

        //public int totalBus = int.Parse(ConfigurationManager.AppSettings["totalBus"]);

        //public int totalBusStation = int.Parse(ConfigurationManager.AppSettings["totalBusStation"]);

        public int totalBus = 3;
        public int totalBusStation = 10;
        private int minShowBus = 500;
        private bool[] ShowBus = new bool[10];
        //公車顯示

        public Form1()
        {
            InitializeComponent();
            Bus[] bus = new Bus[totalBus];  //預設3台公車
            BusStation[] station = new BusStation[totalBusStation];  //預設10個公車站
            Random random = new Random();

            for (int i = 0; i < totalBusStation; i++)   //設定各公車站資訊
            {
                station[i] = new BusStation();
                station[i].StationNumber = i + 1;      //設定站名
                station[i].KM_location = i * 10;   //各公車站相距10KM
            }
            for (int j = 0; j < totalBus; j++)
            {
                rand = random.Next(0, totalBusStation - 1);
                ShowBus[rand] = true;
                minShowBus = minShowBus < rand ? minShowBus : rand;
                bus[j] = new Bus();
                bus[j].KM_location = station[rand].KM_location;  //設定公車所在位置的公里數
                bus[j].speed = 25;
            }
            List<BusStation> busStationList = new List<BusStation>();
            for (int i = 0; i < totalBusStation; i++)   //設定各公車站資訊
            {
                BusStationPanel panel = new BusStationPanel();
                /*
                station[i] = new BusStation();
                station[i].StationNumber = i + 1;      //設定站名
                station[i].KM_location = i * 15;   //各公車站相距15KM
                */
                busStationList.Add(station[i]);

                this.Controls.Add(panel);
                int count = busStationList.Count;
                panel.Location = new Point(20, 40 + 50 * (count - 1));
                panel.Size = new Size(250, 40);
                panel.TabIndex = 0;

                for (int j = 0; j <= i; j++)
                {
                    if (ShowBus[j] == true)
                    {
                        if (i == j)
                            station[i].busTime = 0;
                        else
                            station[i].busTime = (station[j].distance(station[j], station[i])) / 30 * 60;
                    }

                    //station[i].stationMessage = station[i].busTime.ToString();
                }
                panel.SetBusStation(station[i], ShowBus[i]);   //設定BusStation狀態
            }

            //MessageBox.Show("OK");
        }
    }
}