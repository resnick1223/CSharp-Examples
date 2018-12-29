using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class 小火龍 : 火系寶可夢
    {
        public override void 攻擊(寶可夢 另一隻)
        {
            Console.WriteLine("小火龍發動攻擊");
        }
    }
}