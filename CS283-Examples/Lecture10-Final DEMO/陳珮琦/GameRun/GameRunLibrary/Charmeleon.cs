using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Charmeleon : Charmander
    {
        public Charmeleon() : base()
        {
            Name = "火恐龍";
            Number = 5;
            CP = Pokemon.RandomGenerator.Next(430, 580);
            Weight = Pokemon.RandomGenerator.NextDouble(10.5, 19.5);
            Height = Pokemon.RandomGenerator.NextDouble(0.9, 1.1);
            HP = 58;
            CurrentHP = 58;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 100;
        }
    }
}