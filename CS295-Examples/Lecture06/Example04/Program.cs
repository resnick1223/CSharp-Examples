using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 4, 8, 6, 9, 7 };
            int count = 0;
            for (int red = 0; red < numbers.Length; red++)
            {
                //Console.WriteLine("Red: {0} ", red);
                //.Write("", numbers[red]);
                for (int yellow = red + 1; yellow < numbers.Length; yellow++)
                {
                    count++;
                    //Console.WriteLine("Yellow: {0}", yellow);

                    if (numbers[red] + numbers[yellow] == 10)
                    {
                        Console.WriteLine("{0} + {1} = 10", numbers[red], numbers[yellow]);
                        break;
                    }
                }
            }
            Console.WriteLine("count: {0}", count);
        }
    }
}