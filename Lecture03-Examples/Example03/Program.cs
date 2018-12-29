using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonRunLibrary;
using EasyMathLibrary;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GameController PokemonGo = new GameController();
            PokemonGo.StartConsole();
        }
    }
}