using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("請輸入姓名:");
            Console.WriteLine("Hello {1}{0}{1}", Console.ReadLine());
        }
    }
}