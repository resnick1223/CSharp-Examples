using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Pidgeot : Pidgeotto
    {
        public Pidgeot() : base()
        {
            Name = "大比鳥";
            Number = 18;
            CP = Pokemon.RandomGenerator.Next(390, 500);
            Weight = Pokemon.RandomGenerator.NextDouble(37.5, 40.0);
            Height = Pokemon.RandomGenerator.NextDouble(1.2, 1.7);
            HP = 83;
            CurrentHP = 83;
            PowerStardust = 2500;
            PowerUpCandy = 2;
        }
    }
}