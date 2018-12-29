using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimBus
{
    public class BusStation
    {
        public int busStation;
        public double busTime;

        public double kM_location;
        public bool showBus;
        public int stationNumber;

        public double KM_location
        {
            get
            {
                return kM_location;
            }

            set
            {
                kM_location = value;
            }
        }

        public int StationNumber
        {
            get
            {
                return stationNumber;
            }

            set
            {
                stationNumber = value;
            }
        }

        public double distance(BusStation value1, BusStation value2)
        {
            return value2.KM_location - value1.KM_location;
        }
    }
}