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
            Console.Write("請輸入一個數字:");
            try
            {
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("您輸入的是{0}", number1);
            }
            catch
            {
                Console.WriteLine("輸入有問題喔!");
            }
        }
    }
}