using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Wartortle : Squirtle
    {
        public Wartortle() : base()
        {
            Name = "卡咪龜";
            Number = 8;
            CP = RandomGenerator.Next(420, 550);
            Weight = RandomGenerator.NextDouble(20.8, 22.5);
            Height = RandomGenerator.NextDouble(0.8, 1.1);
            HP = 59;
            CurrentHP = 59;
            PowerStardust = 2200;
            PowerUpCandy = 2;
            EvolveCandy = 100;
        }
    }
}