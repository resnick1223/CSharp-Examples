using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class Pokemon : Character
    {
        protected int nationalNo;

        public int NationalNo
        {
            get => nationalNo;
            set => nationalNo = value >= 1 ? value : 1;
        }

        public override int Hp
        {
            get { return hp; }

            set
            {
                if (value < 0)
                    hp = 0;
                else if (value > 2000)
                    hp = 2000;
                else
                    hp = value;
            }
        }

        public abstract void Attack(Pokemon other);
    }
}