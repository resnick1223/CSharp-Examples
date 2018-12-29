using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(1, 11);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}