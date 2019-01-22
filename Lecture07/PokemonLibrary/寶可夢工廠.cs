using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    // PokemonFactory
    // 靜態工廠方法模式
    public class 寶可夢工廠
    {
        // CreateInstance(...)
        public static 寶可夢 產生寶可夢實例(int id)
        {
            switch (id)
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