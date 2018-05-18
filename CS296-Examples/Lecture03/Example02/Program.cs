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
            string message = "Hello World";
            Console.Write("請選擇你要的字元位置");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("message 的 第{0}個 字元是{1}", index, message[index]);
        }
    }
}