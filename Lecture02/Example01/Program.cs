using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.Write("請輸入a: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("a輸入錯誤，請重新執行");
                return;
            }
            Console.Write("請輸入b: ");
            try
            {
                b = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("b輸入錯誤，請重新執行");
                return;
            }
            
            Console.WriteLine("a = {0}, b = {1}", a, b);
        }
    }
}
