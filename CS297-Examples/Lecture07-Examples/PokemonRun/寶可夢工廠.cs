using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRun
{
    public class 寶可夢工廠
    {
        public static 寶可夢 創建(int 編號)
        {
            switch (編號)
            {
                case 1:
                    return new 妙蛙種子();
                case 2:
                    return new 妙蛙草();
                case 3:
                    return new 妙蛙花();
                case 4:
                    return new 小火龍();
                default:
                    return new 妙蛙種子();
            }
        }
    }
}
