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
            // 1. 建立一個亂數產生器
            Random random = new Random();
            // 2. 建立一個陣列 儲存結果
            int[] numbers = new int[4];
            bool used = false;

            // 3. 用迴圈 一個一個產生亂數
            for (int index = 0; index < numbers.Length; index++)
            {
                // 4. 做 產生亂數的動作 當 發現用過了 就再執行一次
                do
                {
                    // 假設 數字沒被用過
                    used = false;

                    // 產生現在的亂數
                    int currentNumber = random.Next(10);
                    numbers[index] = currentNumber;

                    // 往前檢查
                    for (int index2 = 0; index2 < index; index2++)
                    {
                        // 前面那個數字
                        int previousNumber = numbers[index2];

                        // 用過了的意思 = 前面的數字 等於 現在的數字
                        used = previousNumber == currentNumber;
                        // 如果 發現 用過了
                        if (used)
                            // 跳出檢查
                            break;
                    }
                    //當用過了 就重新丟
                } while (used);

                Console.WriteLine(numbers[index]);
            }
        }
    }
}