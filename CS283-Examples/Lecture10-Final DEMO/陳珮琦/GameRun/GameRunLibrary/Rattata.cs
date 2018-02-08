using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Rattata : Pokemon
    {
        public Rattata() : base()
        {
            Name = "小拉達";
            Number = 19;
            CP = Pokemon.RandomGenerator.Next(50, 255);
            Weight = Pokemon.RandomGenerator.NextDouble(2.5, 3.9);
            Height = Pokemon.RandomGenerator.NextDouble(0.2, 0.4);
            HP = 30;
            CurrentHP = 30;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 25;
            Type.Add(PokemonType.NORMAL);
        }
    }
}