using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04_ForLoopCreateRandomNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();

            for (int index = 1; index <= 20; index++)
            {
                Console.WriteLine(random.Next(1, 100));
            }
        }
    }
}