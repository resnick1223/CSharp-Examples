using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonRunLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur() : base()
        {
            Name = "妙蛙草";
            Number = 2;
            HP = 67;
            CP += Pokemon.RandomGenerator.Next(100, 200);
            CurrentHP = 67;
            PowerStardust = 2200;
            PowerUpCandy = 2;
            EvolveCandy = 100;
        }
    }
}