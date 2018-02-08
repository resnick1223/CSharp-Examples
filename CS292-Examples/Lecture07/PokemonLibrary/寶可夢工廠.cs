using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public class 寶可夢工廠
    {
        public static 寶可夢 產生(int 寶可夢編號)
        {
            switch (寶可夢編號)
            {
                case 1:
                    return new 妙蛙種子();

                case 4:
                    return new 小火龍();

                case 43:
                    return new 走路草();

                default:
                    return new 妙蛙種子();
            }
        }
    }
}