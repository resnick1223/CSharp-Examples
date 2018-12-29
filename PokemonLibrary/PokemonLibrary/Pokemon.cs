using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class Pokemon
    {
        public int NationalNo { get; set; }
        public string Name { get; set; }

        protected float height;

        public virtual float Height
        {
            get => height;
            set => height = value;
        }

        protected float weight;

        public virtual float Weight
        {
            get => weight;
            set => weight = value;
        }

        protected int maxHp;

        public virtual int MaxHp
        {
            get => maxHp;
            set => maxHp = value;
        }

        public int CurrentHp { get; set; }

        public int PowerUpStardust { get; set; }
        public int PowerUpCandy { get; set; }

        protected int Iv { get; set; }

        protected int cp;

        public virtual int Cp
        {
            get => cp;
            set => cp = 2 * value + 1;
        }

        protected static Random random;

        public Pokemon()
        {
            if (Pokemon.random == null)
                Pokemon.random = new Random();
        }

        public override string ToString()
        {
            return string.Format("National No: {0}, Name: {1}, HP: {2}/{3}, Height: {4}, Weight: {5}, Stardust: {6}, Candy: {7}"
                , NationalNo
                , Name
                , CurrentHp
                , MaxHp
                , Height
                , Weight
                , PowerUpStardust
                , PowerUpCandy);
        }
    }
}