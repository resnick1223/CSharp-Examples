using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03_ForLoopCreateArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[100];
            for (int index = 0; index < numbers.Length; index++)
            {
                int number = index + 1;
                numbers[index] = number;
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}