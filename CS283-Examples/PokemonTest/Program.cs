using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunLibrary;

namespace PokemonTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon p1 = PokemonFactory.Generate();
            Pokemon p2 = PokemonFactory.Generate();
            Console.WriteLine("P1攻擊P2前:");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            p1.Attack(p2);
            Console.WriteLine("P1攻擊P2後:");
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}