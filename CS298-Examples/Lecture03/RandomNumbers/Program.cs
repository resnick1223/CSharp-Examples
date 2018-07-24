using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[42];
            for(int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = index + 1;
                Console.WriteLine(index + 1);
            }

            Random random = new Random();
            for(int count = 1; count <= 84; count++)
            {
                int selectedIndex1 = random.Next(numbers.Length);
                int selectedIndex2 = selectedIndex1 == 0 ? 1 : selectedIndex1 - 1;
                int tmp = numbers[selectedIndex1];
                numbers[selectedIndex1] = numbers[selectedIndex2];
                numbers[selectedIndex2] = tmp;
            }

            for (int index = 0; index < numbers.Length; index++)
            {
                Console.WriteLine(numbers[index]);
            }
        }
    }
}
