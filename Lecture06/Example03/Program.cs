using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyToolBox;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            RandomExtension myRandom = new RandomExtension();
            ;
            for (int index = 1; index <= 10; index++)
                Console.WriteLine(myRandom.NextDouble(1.2, 3.3));

            Random random = new Random();
            for (int index = 1; index <= 10; index++)
                Console.WriteLine(random.NextDouble(1.2, 3.3));
        }
    }
}