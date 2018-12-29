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
            int[] numbers = new int[10];
            for (int index = 0; index < numbers.Length; index++)
            {
                numbers[index] = index + 1;
                Console.WriteLine("numbers[{0}] = {1}", index, numbers[index]);
            }
        }
    }
}