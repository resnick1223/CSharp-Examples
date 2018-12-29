using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10000];
            Random random = new Random();
            int count = 0;

            for(int index = 0; index < numbers.Length - 1; index++)
            {
                numbers[index] = random.Next(0, 10);
                int number1 = numbers[index];

                for (int index2 = index + 1; index2 < numbers.Length; index2++)
                {
                    int number2 = numbers[index2];

                    if (number1 + number2 == 9)
                    {
                      //  Console.WriteLine("index = {0}, index2 = {1}", index, index2);
                      Console.WriteLine("{0} + {1} = 9", number1, number2);
                    }
                    count++;
                }
            }
            Console.WriteLine("搜尋次數: {0}", count);
        }
    }
}
