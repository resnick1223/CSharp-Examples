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
            Console.Write("我今天心情很{0}{1}{0}"
                , Console.ReadLine()
                , Console.ReadLine());
        }
    }
}