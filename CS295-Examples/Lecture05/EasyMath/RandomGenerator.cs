using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class RandomGenerator
    {
        public static int[] Generate(int count, int min, int max)
        {
            Random random = new Random();
            int[] numbers = new int[count];
            for (int index = 0;
                index < numbers.Length;
                index++)
            {
                numbers[index] = random.Next(min, max);
            }

            return numbers;
        }
    }
}