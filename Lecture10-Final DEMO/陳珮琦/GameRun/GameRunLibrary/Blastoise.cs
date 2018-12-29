using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Blastoise : Wartortle
    {
        public Blastoise() : base()
        {
            Name = "水箭龜";
            Number = 9;
            CP = RandomGenerator.Next(530, 1150);
            Weight = RandomGenerator.NextDouble(83.8, 85.5);
            Height = RandomGenerator.NextDouble(1.4, 1.6);
            HP = 79;
            CurrentHP = 79;
            PowerStardust = 2200;
            PowerUpCandy = 2;
        }
    }
}