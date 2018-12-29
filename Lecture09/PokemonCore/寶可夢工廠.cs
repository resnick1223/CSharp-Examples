using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonCore
{
    public class 寶可夢工廠
    {
        public static 寶可夢 產生寶可夢(int 編號)
        {
            switch (編號)
            {
                case 1:
                    return new 妙蛙種子();
                case 2:
                    return new 妙蛙草();
                case 4:
                    return new 小火龍();
                case 5:
                    return new 火恐龍();
                default:
                    return new 妙蛙種子();
            }
        }
    }
}
