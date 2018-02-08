using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur()
        {
            Name = "妙蛙草";
            Hp = 133;
            NationalNumber = 2;
            CurrentHp = Hp;
            attack = 25;
            defense = 25;
            speed = 15;
            iv = 120;
        }

        public override void Attack(Pokemon other)
        {
            base.Attack(other);
            other.CurrentHp -= 15;
        }

        public override string ToString()
        {
            return string.Format("這行在Pokemon\n Number:{0}, Name:{1}", NationalNumber, Name) + "妙蛙草進化後妙蛙花";
        }
    }
}