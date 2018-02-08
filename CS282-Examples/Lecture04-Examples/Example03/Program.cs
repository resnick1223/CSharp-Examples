using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RandomGenerator random = new RandomGenerator();
            List<int> numbers = new List<int>();
            for (int index = 0; index < 10; index++)
                numbers.Add(index);

            for (int count = 1; count <= 4; count++)
            {
                int index = random.Next(0, numbers.Count);
                Console.WriteLine(numbers[index]);
                numbers.Remove(numbers[index]);
            }
        }
    }
}