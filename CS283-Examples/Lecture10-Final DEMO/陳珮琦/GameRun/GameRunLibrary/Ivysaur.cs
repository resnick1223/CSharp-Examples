using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur() : base()
        {
            Name = "妙蛙草";
            Number = 2;
            CP = RandomGenerator.Next(475, 550);
            Weight = RandomGenerator.NextDouble(6.8, 10.0);
            Height = RandomGenerator.NextDouble(0.8, 1.3);
            HP = 67;
            CurrentHP = 67;
            PowerStardust = 2200;
            PowerUpCandy = 2;
            EvolveCandy = 100;
        }
    }
}