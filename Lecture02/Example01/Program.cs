using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[3] { 1, 2, 3 };
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);
        }
    }
}