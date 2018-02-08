using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            寶可夢 寶可夢1 = 寶可夢工廠.產生(1);
            寶可夢 寶可夢2 = 寶可夢工廠.產生(4);
            寶可夢1.Cp = 10000;
            寶可夢1.攻擊(寶可夢2);
            Console.WriteLine(寶可夢1);
        }
    }
}