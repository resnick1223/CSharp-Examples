using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Charmander : Pokemon
    {
        public Charmander() : base()
        {
            Name = "小火龍";
            Number = 4;
            CP = Pokemon.RandomGenerator.Next(430, 480);
            Weight = Pokemon.RandomGenerator.NextDouble(5.5, 6.8);
            Height = Pokemon.RandomGenerator.NextDouble(0.5, 0.8);
            HP = 54;
            CurrentHP = 54;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            EvolveCandy = 25;
            Type.Add(PokemonType.FIRE);
        }
    }
}