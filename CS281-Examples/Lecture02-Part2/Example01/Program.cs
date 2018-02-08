using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入共要幾個數字:");
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write("請輸入第{0}個數字:", index + 1);
                numbers[index] = int.Parse(Console.ReadLine());
            }
        }
    }
}