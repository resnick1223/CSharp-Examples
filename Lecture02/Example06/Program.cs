using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 };

            // 反覆器
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            List<int> numberList = new List<int>();
            numberList.Add(6);
            numberList.Add(3);
            numberList.Add(7);
            Console.WriteLine(numberList.Count);
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
        }
    }
}