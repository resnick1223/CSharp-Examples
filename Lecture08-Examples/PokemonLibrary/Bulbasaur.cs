using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur()
        {
            NationalNo = 1;
            Name = "妙蛙種子";
            AttackValue = 49;
            Defense = 49;
            Hp = 45;
        }

        public override void Attack(Pokemon other)
        {
            other.Hp -= (int)(AttackValue * 0.2);
            Console.WriteLine("{0}攻擊力:{1}", Name, AttackValue);
            Console.WriteLine("{0}發動攻擊", Name);
            Console.WriteLine("{0}受到攻擊，{0}的Hp剩餘{1}", other.Name, other.Hp);
        }
    }
}