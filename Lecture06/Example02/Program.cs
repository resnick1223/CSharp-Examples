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
            // 建立一個從0~9的清單

            // 建立一個空的清單
            List<int> numbers = new List<int>();

            // 用迴圈追加清單的內容
            for (int number = 0; number < 10; number++)
                numbers.Add(number);

            // 需要一個亂數產生器
            Random random = new Random();

            // 產生四個亂數
            // 執行 四次 取出數字 並且從清單刪除的動作
            for (int count = 1; count <= 4; count++)
            {
                // 亂數產生要刪除的編號
                int index = random.Next(numbers.Count);
                // 取出拿到的
                int number = numbers[index];
                Console.WriteLine(number);
                // 刪掉已經拿到的
                numbers.Remove(number);
            }
        }
    }
}