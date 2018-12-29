using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入上限:");
            int max = int.Parse(Console.ReadLine());
            int total = 0;
            int number = 1;
            while (total <= max)
            {
                total += number++;
            }

            Console.WriteLine("Total:{0}, number:{1}", total, number);
        }
    }
}