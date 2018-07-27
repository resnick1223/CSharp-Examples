using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10000];
            Random random = new Random();
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            int index = 0;
            int count = 0;
            for (index = 0; index < numbers.Length; index++)
            {
                numbers[index] = random.Next(0, 10);
                int number = numbers[index];
                if (!dictionary.ContainsKey(number))
                    dictionary.Add(number, index);
                count++;
            }

            for (index = 0; index < numbers.Length; index++)
            {
                int number1 = numbers[index];
                if (dictionary.ContainsKey(9 - number1))
                {
                    Console.WriteLine("{0} + {1} = 9", number1, 9 - number1);
                }

                count++;
            }

            Console.WriteLine("搜尋次數: {0}", count);


        }
    }
}
