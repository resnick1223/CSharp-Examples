using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 亂數產生器的物件 random
            Random random = new Random(1234);

            for (int index = 1; index <= 10; index++)
            {
                int number = random.Next(10);
                Console.WriteLine(number);
            }
        }
    }
}