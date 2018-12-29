using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public class Butterfree : Metapod
    {
        public Butterfree() : base()
        {
            Name = "巴大蝶";
            Number = 12;
            CP = Pokemon.RandomGenerator.Next(300, 400);
            Weight = Pokemon.RandomGenerator.NextDouble(30.0, 33.0);
            Height = Pokemon.RandomGenerator.NextDouble(0.9, 1.3);
            HP = 60;
            CurrentHP = 60;
            PowerStardust = 2500;
            PowerUpCandy = 2;
            Type.Add(PokemonType.FLYING);
        }
    }
}