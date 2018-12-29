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
            int number = 0;
            bool success = int.TryParse(Console.ReadLine(), out number);
            if (success)
            {
                Console.WriteLine("您輸入的數字是{0}", number);
            }
            else
            {
                Console.WriteLine("輸入不正確，請重新輸入");
            }
        }
    }
}