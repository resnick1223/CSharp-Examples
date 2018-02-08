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
        public int AttackValue { get; set; }
        public int Defense { get; set; }

        private int hp;

        public int Hp
        {
            get => hp;
            set
            {
                hp = value < 0 ? 0 : value;
            }
        }

        public abstract void Attack(Pokemon other);
    }
}