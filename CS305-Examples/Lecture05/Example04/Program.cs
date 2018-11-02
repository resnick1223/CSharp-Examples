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
            // 亂數產生器 物件
            Random random = new Random();

            int[] numbers = new int[20];
            for (int index = 0; index < numbers.Length; index++)
            {
                for (int index2 = 0; index2 < index; index2++)
                {
                    //怎麼做?
                    // numbers[index] == numbers[index2]
                }
                Console.WriteLine(random.Next(10));
            }
        }
    }
}