using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Pidgeotto : Pidgey
    {
        public Pidgeotto() : base()
        {
            Name = "比比鳥";
            Number = 17;
            CP = Pokemon.RandomGenerator.Next(290, 350);
            Weight = Pokemon.RandomGenerator.NextDouble(28.0, 30.5);
            Height = Pokemon.RandomGenerator.NextDouble(1.0, 1.2);
            HP = 63;
            CurrentHP = 63;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 50;
        }
    }
}