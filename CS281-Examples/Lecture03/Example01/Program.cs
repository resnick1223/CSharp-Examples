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
            Console.Write("請輸入數字A:");
            int a = int.Parse(Console.ReadLine());
            Console.Write("請輸入數字B:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} > {1} 的結果是:{2}", a, b, a > b);
            Console.WriteLine("{0} >= {1} 的結果是:{2}", a, b, a >= b);
            Console.WriteLine("{0} < {1} 的結果是:{2}", a, b, a < b);
            Console.WriteLine("{0} <= {1} 的結果是:{2}", a, b, a <= b);
            Console.WriteLine("{0} == {1} 的結果是:{2}", a, b, a >= b);
        }
    }
}