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
            Console.Write("請輸入要處理幾個數字:");
            int count = 0;
            try
            {
                count = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("輸入錯誤");
                return;
            }

            List<int> numbers = new List<int>();
            int total = 0;
            for (int index = 1; index <= count; index++)
            {
                if (index == 3)
                    continue;
                Console.Write("請輸入第{0}個數字:", index);
                int number = 0;
                try
                {
                    number = int.Parse(Console.ReadLine());
                    numbers.Add(number);
                    total += number;
                }
                catch (Exception e)
                {
                    Console.WriteLine("輸入錯誤");
                    return;
                }
            }
            string result = string.Empty;
            foreach (int number in numbers)
            {
                result += string.Format("{0} + ", number);
            }
            Console.WriteLine(result);
        }
    }
}