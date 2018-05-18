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
            int[] numbers = new int[3];
            Random random = new Random();
            int total = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(1, 11);
                total += numbers[index];
                Console.WriteLine(numbers[index]);
            }
            Console.WriteLine(total);
        }
    }
}