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
            int number1 = 0;
            int number2 = 0;

            Console.Write("請輸入第一個數字:");
            bool parseSuccess = int.TryParse(Console.ReadLine(), out number1);

            if (!parseSuccess)
            {
                Console.WriteLine("第一個數字輸入錯誤");
                return;
            }
            Console.Write("請輸入第二個數字:");
            parseSuccess = int.TryParse(Console.ReadLine(), out number2);
            if (!parseSuccess)
            {
                Console.WriteLine("第二個數字輸入錯誤");
                return;
            }

            Console.WriteLine(number1 + number2);
        }
    }
}