using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];
            int max = 0;
            int min = 0;
            int total = 0;
            for(int index = 0; index < numbers.Length; index++)
            {
                // 產生下一個亂數
                numbers[index] = random.Next(1, 101);

                // 如果 index = 0 那最大值 就是 這個亂數
                if(index == 0)
                {
                    max = numbers[index];
                    min = numbers[index];
                }
                else
                {
                    // 不然 這個亂數 比 之前的最大值 大嗎?
                    if(numbers[index] > max)
                    {
                        // 是的話 最大值 換成這傢伙
                        max = numbers[index];
                    }

                    if(numbers[index] < min)
                    {
                        min = numbers[index];
                    }
                }

                total += numbers[index];
                Console.WriteLine("numbers[{0}] = {1}", index, numbers[index]);
            }
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Total = {0}", total);
            Console.WriteLine("Average = {0}", (float)total / numbers.Length);

        }
    }
}
