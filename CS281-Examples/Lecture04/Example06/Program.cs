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
            Console.Write("1+2+3....+??: 請輸入??:");
            int end = int.Parse(Console.ReadLine());
            int skip = 1;
            int userInput = 0;
            do
            {
                Console.Write("請輸入要跳過的數字:");
                userInput = int.Parse(Console.ReadLine());
                if (userInput > end || userInput < 1)
                    Console.WriteLine("輸入錯誤，請重新輸入");
            } while (userInput > end || userInput < 1);

            skip = userInput;
            int total = 0;
            string result = "";
            for (int number = 1; number <= end; number++)
            {
                if (number == skip)
                {
                    continue;
                }
                total = total + number;
                if (number < end)
                    result = result + string.Format("{0} + ", number);
                else
                    result = result + string.Format("{0} = {1}", number, total);
            }

            Console.WriteLine(result);
        }
    }
}