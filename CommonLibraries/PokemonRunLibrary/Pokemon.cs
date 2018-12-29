using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonRunLibrary
{
    public enum PokemonType
    { GRASS, POISSON, FIRE, FLYING, DRAGON, WATER, BUG }

    public class Pokemon
    {
        private static Random random;

        public int Number;
        public string Name;
        public int HP;
        private int currentHP;
        public int CP;
        public double Weight;
        public double Height;
        public List<PokemonType> Type = new List<PokemonType>();
        public int PowerUpCandy;
        public int PowerStardust;
        public int EvolveCandy;

        public string ImageFileName
        {
            get
            {
                if (this.Number < 10)
                    return "00" + this.Number;
                else if (Number >= 10 && Number < 100)
                    return "0" + this.Number;
                else
                    return this.Number.ToString();
            }
        }

        public Pokemon()
        {
            CP = Pokemon.RandomGenerator.Next(450, 500);
            Height = Pokemon.RandomGenerator.NextDouble(0.5, 0.88);
            Weight = Pokemon.RandomGenerator.NextDouble(5.0, 7.2);
        }

        public static Random RandomGenerator
        {
            get
            {
                if (random == null)
                    random = new Random();
                return random;
            }
        }

        public int CurrentHP
        {
            get => currentHP;
            set
            {
                this.currentHP = value < 0 ? 0 : value;
            }
        }

        public virtual void Attack(Pokemon other)
        {
            other.CurrentHP -= 10;
        }

        public override string ToString()
        {
            return string.Format(@"National No.{0},
Name:{1},
CP:{2},
HP:{3}/{4}", Number, Name, CP, CurrentHP, HP);
        }
    }
}