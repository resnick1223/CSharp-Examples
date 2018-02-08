using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyMathLibrary;

namespace SimBus
{
    public partial class BusStationPanel : UserControl
    {
        public BusStation busStation;

        public BusStationPanel()
        {
            InitializeComponent();
        }

        public void Render()
        {
            BusStationNameLabel.Text = string.Format("Station {0}", this.busStation.stationNumber);
            BusStationKMLabel.Text = string.Format("{0} KM", this.busStation.kM_location);
            BusTimeLabel.Text = string.Format("{0} min", this.busStation.busTime);
            BusPictureBox.Visible = busStation.showBus;
        }

        public void SetBusStation(BusStation busStation, bool busVisible)
        {
            this.busStation = busStation;
            this.busStation.showBus = busVisible;
            //if (busVisible == true)
            //    this.busStation.stationNumber
            Render();
        }
    }
}