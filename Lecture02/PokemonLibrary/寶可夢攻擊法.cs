using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public class 寶可夢攻擊法 : 寶可夢行為, IAttackBehavior
    {
        public void Attack(Character character)
        {
            Console.WriteLine("寶可夢攻擊囉");
        }
    }
}