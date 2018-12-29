using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[4];
            Random random = new Random();
            numbers[0] = random.Next(10);
            int count = 0;
            for (int index = 1; index < numbers.Length; index++)
            {
                bool exits = false;

                // 先產生亂數 如果 判定出現過了 就繼續產生
                do
                {
                    count++;
                    // 產生亂數
                    numbers[index] = random.Next(10);

                    // 判定是否出現過? 往前面的號碼檢查 1 --> 0, 2 --> 0, 1
                    for (int index2 = 0; index2 < index; index2++)
                    {
                        exits = numbers[index] == numbers[index2];
                        if (exits)
                            break;
                    }
                } while (exits);
            }

            foreach (var number in numbers)
            {
                Console.Write(number);
            }
            Console.WriteLine();
            Console.WriteLine("共費{0}次", count);
        }
    }
}