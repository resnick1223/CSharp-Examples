using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRun;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            寶可夢 某種寶可夢1 = 寶可夢工廠.創建(int.Parse(args[0]));
            寶可夢 某種寶可夢2 = 寶可夢工廠.創建(int.Parse(args[1]));

        }
    }
}
