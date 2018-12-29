using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace GameRunLibrary
{
    public enum PokemonType
    {
        GRASS, POISSON, FIRE, FLYING, DRAGON, WATER, BUG, NORMAL,
        ELECTRIC, GROUND, FAIRY, FIGHTING, PSYCHIC, ROCK, STEEL, ICE, GHOST
    }

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
            Weight = Pokemon.RandomGenerator.NextDouble(5.0, 7.2);
            Height = Pokemon.RandomGenerator.NextDouble(0.5, 0.88);
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
            get
            {
                return currentHP;
            }

            set
            {
                currentHP = value < 0 ? 0 : value;
            }
        }

        public virtual void Attack(Player player)
        {
            if (player.defenseType == DefenseType.BACE)
                player.CurrentHP -= 8;
            else if (player.defenseType == DefenseType.FIRST)
                player.CurrentHP -= 5;
            else if (player.defenseType == DefenseType.SECOND)
                player.CurrentHP -= 2;
            else if (player.defenseType == DefenseType.FINAL)
                player.CurrentHP -= 1;
        }
    }
}