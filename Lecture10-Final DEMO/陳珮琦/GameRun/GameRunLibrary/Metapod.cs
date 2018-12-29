using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Metapod : Caterpie
    {
        public Metapod() : base()
        {
            Name = "鐵甲蛹";
            Number = 11;
            CP = Pokemon.RandomGenerator.Next(150, 250);
            Weight = Pokemon.RandomGenerator.NextDouble(8.0, 10.0);
            Height = Pokemon.RandomGenerator.NextDouble(0.5, 0.8);
            HP = 50;
            CurrentHP = 50;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 50;
        }
    }
}