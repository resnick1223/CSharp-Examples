using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Raticate : Rattata
    {
        public Raticate() : base()
        {
            Name = "拉達";
            Number = 20;
            CP = Pokemon.RandomGenerator.Next(350, 415);
            Weight = Pokemon.RandomGenerator.NextDouble(16.5, 18.9);
            Height = Pokemon.RandomGenerator.NextDouble(0.5, 0.8);
            HP = 55;
            CurrentHP = 55;
            PowerStardust = 2500;
            PowerUpCandy = 2;
        }
    }
}