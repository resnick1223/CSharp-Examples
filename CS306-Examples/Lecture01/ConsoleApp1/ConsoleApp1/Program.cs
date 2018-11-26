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
            // 主控台 列印一行
            Console.Write("請輸入名字: ");
            Console.WriteLine("Hello {0}", Console.ReadLine());
            Console.WriteLine("我今天心情{1}{0}{0}", "好", "很");
        }
    }
}