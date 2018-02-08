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
            int number1 = 0;
            int number2 = 0;
            Console.Write("請輸入第一個數字:");
            try
            {
                number1 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("第一個數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }

            Console.Write("請輸入第二個數字:");
            try
            {
                number2 = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("第二個數字輸入錯誤");
                Console.WriteLine("錯誤訊息:\n" + e.ToString());
                return;
            }
            Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
        }
    }
}