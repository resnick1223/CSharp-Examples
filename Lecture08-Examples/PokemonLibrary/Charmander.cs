using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public class Charmander : Pokemon
    {
        public Charmander()
        {
            NationalNo = 4;
            Name = "小火龍";
            AttackValue = 52;
            Defense = 43;
            Hp = 39;
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