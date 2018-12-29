using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Weedle : Pokemon
    {
        public Weedle() : base()
        {
            Name = "獨角蟲";
            Number = 13;
            CP = Pokemon.RandomGenerator.Next(50, 196);
            Weight = Pokemon.RandomGenerator.NextDouble(2.5, 3.5);
            Height = Pokemon.RandomGenerator.NextDouble(0.1, 0.4);
            HP = 40;
            CurrentHP = 40;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 12;
            Type.Add(PokemonType.BUG);
            Type.Add(PokemonType.POISSON);
        }
    }
}