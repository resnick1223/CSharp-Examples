using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pokemonName = "閃電鳥";
            int pokemonCp = 1890;
            float pokemonWeight = 30.87f;

            Console.WriteLine("寶可夢的名稱:{0}, CP:{1}, Weight:{2}kg"
                , pokemonName, pokemonCp, pokemonWeight);
        }
    }
}