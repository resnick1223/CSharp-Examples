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
            Console.Write("請輸入使用者名稱:");
            string name = Console.ReadLine();
            Console.Write("請輸入密碼:");
            string password = Console.ReadLine();

            Console.WriteLine("嗨，{0}，歡迎回來!", name);
        }
    }
}