using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03_BreakAndContinue
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int total = 0;
            int[] skips = new int[] { 11, 13 };
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int index = 0; index < numbers.Length; index++)
            {
                int number = numbers[index];
                if (FindOne(skips, number) != -1)
                    continue;
                total += number;
            }
            Console.WriteLine("Total = {0}", total);
        }

        private static int FindOne(int[] numbers, int target)
        {
            int index = -1;
            for (int index2 = 0; index2 < numbers.Length; index2++)
            {
                if (numbers[index2] == target)
                {
                    index = index2;
                    break;
                }
            }

            return index;
        }
    }
}