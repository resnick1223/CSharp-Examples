using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[4];
            for (int index = 0; index < 4; index++)
            {
                numbers[index] = random.Next(1, 7);
                Console.WriteLine(numbers[index]);
            }
        }
    }
}