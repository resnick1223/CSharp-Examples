using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Pidgey : Pokemon
    {
        public Pidgey() : base()
        {
            Name = "波波";
            Number = 16;
            CP = Pokemon.RandomGenerator.Next(50, 252);
            Weight = Pokemon.RandomGenerator.NextDouble(1.5, 1.9);
            Height = Pokemon.RandomGenerator.NextDouble(0.2, 0.4);
            HP = 40;
            CurrentHP = 40;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 12;
            Type.Add(PokemonType.NORMAL);
            Type.Add(PokemonType.FLYING);
        }
    }
}