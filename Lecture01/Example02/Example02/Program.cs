using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 儲存資料
            int pokemonHp = 30;
            int pokemonCurrentHp = 10;

            // 標準輸出結果
            Console.WriteLine("{0}/{1}", pokemonCurrentHp, pokemonHp);
        }
    }
}