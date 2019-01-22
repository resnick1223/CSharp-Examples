using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 向上轉型      用工廠方法 帶入參數 產生物件
            寶可夢 寶可夢1 = 寶可夢工廠.產生寶可夢實例(1);

            寶可夢 寶可夢2 = 寶可夢工廠.產生寶可夢實例(2);
        }
    }
}