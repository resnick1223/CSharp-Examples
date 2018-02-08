using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class 走路草 : 草系寶可夢
    {
        public override void 攻擊(寶可夢 另一隻)
        {
            Console.WriteLine("走路草發動攻擊");
        }
    }
}