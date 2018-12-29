using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public enum OrderBy
    {
        Hp, Number, Cp
    }

    public abstract class Pokemon : IComparable<Pokemon>
    {
        protected int hp;
        protected int currentHp;
        protected int attack;
        protected int defense;
        protected int speed;
        protected int iv;
        public string Name { get; set; }
        public static OrderBy OrderByField;

        public int NationalNumber { get; set; }

        public int Hp
        {
            get => hp;
            set
            {
                //if (value < 0)
                //    this.hp = 0;
                //else
                //    hp = value;

                this.hp = value < 0 ? 0 : value;
            }
        }

        public int CurrentHp
        {
            get => currentHp; set
            {
                this.currentHp = value < 0 ? 0 : value;
            }
        }

        public int Cp
        {
            get
            {
                return defense * 2 + attack * 3 + iv + speed;
            }
        }

        public double Height { get; set; }
        public double Weight { get; set; }

        public int CompareTo(Pokemon other)
        {
            switch (OrderByField)
            {
                case OrderBy.Hp:
                    return Compare(this.Hp, other.Hp);

                case OrderBy.Cp:
                    return Compare(this.Cp, other.Cp);

                default:
                    return Compare(this.NationalNumber, other.NationalNumber);
            }
        }

        protected int Compare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        public abstract void Attack(Pokemon other);

        public override string ToString()
        {
            return string.Format("這行在Pokemon\n Number:{0}, Name:{1}", NationalNumber, Name);
        }
    }
}