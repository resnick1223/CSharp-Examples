using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimBus
{
    public class Bus
    {
        public int busNumber;
        public int direction;  //random

        //public int location;   //random
        public double KM_location;

        //行車方向: 去+1,回-1
        public double speed;   //random : determined by distance/time

        public int whichStation;

        public double bustime(BusStation value1, BusStation value2)
        {
            return (distance(value1, value2) / this.speed) * 60;  //換算成分鐘
        }

        public double distance(BusStation value1, BusStation value2)
        {
            return value2.KM_location - value1.KM_location;
        }
    }
}