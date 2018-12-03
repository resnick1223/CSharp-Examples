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
            int[] numbers = new int[10];
            int total = 0;
            for (int index = 0; index < numbers.Length; index++)
            {
                Console.Write("請輸入第{0}個數字:", index + 1);
                numbers[index] = int.Parse(Console.ReadLine());
                total += numbers[index];
            }

            Console.WriteLine("總和 = {0}, 平均 = {1}", total, ((double)total) / numbers.Length);
        }
    }
}