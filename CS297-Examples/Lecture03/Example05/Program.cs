using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            Random random = new Random();

            for (int index = 0; index < numbers.Length; index++)
            {

                numbers[index] = random.Next(1, 101);
                Console.WriteLine(numbers[index]);
            }
        }
    }
}
