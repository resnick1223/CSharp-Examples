using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokemonLibrary
{
    public class 航海王腳色攻擊行為 : 航海王行為, IAttackBehavior
    {
        public void Attack(Character character)
        {
            Console.WriteLine("航海王攻擊囉");
        }
    }
}