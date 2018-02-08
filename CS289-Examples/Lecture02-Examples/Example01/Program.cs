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
            int A = 1; // 把A初始化為1
            int B = 3;
            bool IsHappy = (A > B);
            Console.WriteLine(IsHappy);
        }
    }
}