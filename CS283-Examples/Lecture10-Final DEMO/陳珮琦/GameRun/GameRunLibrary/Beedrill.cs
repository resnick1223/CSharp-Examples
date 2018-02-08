using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Beedrill : Kakuna
    {
        public Beedrill() : base()
        {
            Name = "大針蜂";
            Number = 15;
            CP = Pokemon.RandomGenerator.Next(350, 400);
            Weight = Pokemon.RandomGenerator.NextDouble(25.5, 29.5);
            Height = Pokemon.RandomGenerator.NextDouble(0.8, 1.2);
            HP = 65;
            CurrentHP = 65;
            PowerStardust = 2500;
            PowerUpCandy = 2;
        }
    }
}