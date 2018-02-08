using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
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
                numbers[index] = random.Next(1, 7);
            }

            for (int index = 0; index < numbers.Length; index++)
            {
                string number =
                    numbers[index] < 0 ?
                    "(" + numbers[index].ToString() + ")" :
                    numbers[index].ToString();
                total += numbers[index];
                if (index < numbers.Length - 1)
                    Console.Write("{0} + ", number);
                else
                    Console.WriteLine("{0} = {1} ", number, total);
            }
        }
    }
}