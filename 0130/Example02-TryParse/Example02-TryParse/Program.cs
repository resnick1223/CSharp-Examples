using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02_TryParse
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number1 = 0;
            int number2 = 0;
            bool success = false;
            Console.Write("請輸入第一個數字:");

            success = int.TryParse(Console.ReadLine(), out number1);
            if (!success)
            {
                PrintErrorMessage("第一個數字");
            }

            Console.Write("請輸入第二個數字:");

            success = int.TryParse(Console.ReadLine(), out number2);
            if (!success)
            {
                PrintErrorMessage("第二個數字");
            }
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        }

        private static void PrintErrorMessage(string title)
        {
            Console.WriteLine("{0}輸入錯誤", title);
            Console.WriteLine("程式結束");
            return;
        }
    }
}