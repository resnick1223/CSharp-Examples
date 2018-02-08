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
            Console.Write("請輸入第一個數字:");
            int number1 = 0;
            bool isConvertable = int.TryParse(Console.ReadLine(), out number1);
            if (!isConvertable)
            {
                Console.WriteLine("第一個數字輸入錯誤");
                return;
            }
            Console.Write("請輸入第二個數字:");
            int number2 = 0;
            isConvertable = int.TryParse(Console.ReadLine(), out number2);
            if (!isConvertable)
            {
                Console.WriteLine("第二個數字輸入錯誤");
                return;
            }
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        }
    }
}