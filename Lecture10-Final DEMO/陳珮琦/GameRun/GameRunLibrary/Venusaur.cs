using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Venusaur : Ivysaur
    {
        public Venusaur() : base()
        {
            Name = "妙蛙花";
            Number = 3;
            CP = RandomGenerator.Next(550, 1100);
            Weight = RandomGenerator.NextDouble(6.8, 7.5);
            Height = RandomGenerator.NextDouble(1.8, 2.0);
            HP = 80;
            CurrentHP = 80;
            PowerStardust = 2200;
            PowerUpCandy = 2;
        }
    }
}