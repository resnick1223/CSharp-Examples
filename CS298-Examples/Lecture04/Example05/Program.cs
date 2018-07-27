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
            int[] numbers = new int[] { 2, 7, 5, 4, 6, 3, 1, 2, 3 };
            bool[] numbersTable = new bool[] { false, false, false, false, false, false, false, false, false, false };
            int count = 0;
            foreach(int number in numbers)
            {
                numbersTable[number] = true;
            }

            Dictionary<int, int> numbersHashTable = new Dictionary<int, int>();
            numbersHashTable.Add(2, 0);

         
            for (int index = 0; index < numbers.Length - 1; index++)
            {
                int number1 = numbers[index];
                int number2 = 9 - number1;
                if (numbersTable[number2] == true)
                {
                        Console.WriteLine("{0} + {1} = 9", number1, number2);
                }
                count++;
            }
            Console.WriteLine("搜尋次數: {0}", count);
        }
    }
}
