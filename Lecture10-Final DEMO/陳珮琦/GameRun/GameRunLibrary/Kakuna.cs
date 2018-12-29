using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Kakuna : Weedle
    {
        public Kakuna() : base()
        {
            Name = "鐵殼蛹";
            Number = 14;
            CP = Pokemon.RandomGenerator.Next(150, 210);
            Weight = Pokemon.RandomGenerator.NextDouble(9.5, 10.5);
            Height = Pokemon.RandomGenerator.NextDouble(0.4, 0.7);
            HP = 45;
            CurrentHP = 45;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 50;
        }
    }
}