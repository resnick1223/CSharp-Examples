using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 8;
            numbers[1] = 7;
            numbers[2] = 5;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            foreach (int number in numbers)
                Console.WriteLine(number);

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(numbers[index]);
            }
        }
    }
}