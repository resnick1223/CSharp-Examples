using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Caterpie : Pokemon
    {
        public Caterpie() : base()
        {
            Name = "綠毛蟲";
            Number = 10;
            CP = Pokemon.RandomGenerator.Next(50, 196);
            Weight = Pokemon.RandomGenerator.NextDouble(2.0, 2.9);
            Height = Pokemon.RandomGenerator.NextDouble(0.1, 0.4);
            HP = 45;
            CurrentHP = 45;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 12;
            Type.Add(PokemonType.BUG);
        }
    }
}