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
            // TODO 建立一個整數陣列
            int[] numbers = new int[100];

            // 建立一個迴圈 編號 從 0 ~ 99
            for (int index = 0; index < numbers.Length; index++)
            {
                // TODO 設定每一個值 為 編號 + 1
                numbers[index] = index + 1;

                Console.WriteLine(numbers[index]);
            }
        }
    }
}