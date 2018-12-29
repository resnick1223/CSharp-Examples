using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            int result = 2 * x + 3 * y;
            return result;
        }

        public int Sum(int start, int end)
        {
            int total = 0;
            for (var count = start; count <= end; count++)
            {
                total += count;
            }
            return total;
        }

        public int Sum(int[] numbers)
        {
            int total = 0;
            for (var count = 0; count < numbers.Length; count++)
            {
                total += numbers[count];
            }
            return total;
        }
    }
}