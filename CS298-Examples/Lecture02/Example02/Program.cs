using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            Random random = new Random();
            for (var count = 0; count < 5; count++)
            {
                numbers[count] = random.Next(1, 100);
                Console.WriteLine(numbers[count]);
            }
        }
    }
}
