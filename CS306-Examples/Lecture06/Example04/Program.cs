using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 建立一個內容是 0, 1, 2, ...., 9的清單
            List<int> numbers = new List<int>();
            for (int index = 0; index < 10; index++)
                numbers.Add(index);

            // 建立一個結果的清單
            List<int> results = new List<int>();

            // 亂數產生器
            Random random = new Random();

            // 取出四個數字
            for (int index2 = 1; index2 <= 4; index2++)
            {
                // 亂數產生要抽出的位置
                int index = random.Next(numbers.Count);

                // 根據位置 拿到數字
                int number = numbers[index];

                // 拿到後加到結果的清單
                results.Add(number);

                // 移除已經用過的數字
                numbers.Remove(number);
            }

            foreach (var number in results)
                Console.Write(number);
        }
    }
}