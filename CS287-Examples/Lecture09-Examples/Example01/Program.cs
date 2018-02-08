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
            int count = 4;
            int[] numbers = new int[10];
            for (int index = 0; index < 10; index++)
                numbers[index] = index;

            string ans = "";
            Random random = new Random();
            for (int index = 0; index < count; index++)
            {
                int selectedIndex = random.Next(index, numbers.Length);
                int a = numbers[index];
                int b = numbers[selectedIndex];
                numbers[index] = b;
                numbers[selectedIndex] = a;
                ans += numbers[index].ToString();
            }
            Console.WriteLine(ans);
            string result = "0A0B";
            while (result != "4A0B")
            {
                string userAns = Console.ReadLine();
                int aCount = 0;
                int bCount = 0;
                for (int index = 0; index < userAns.Length; index++)
                {
                    //for (int index2 = 0; index2 < result.Length; index2++)
                    //{
                    //    if (result[index2] == userAns[index])
                    //    {
                    //        if (index2 == index)
                    //            aCount++;
                    //        else
                    //            bCount++;
                    //    }
                    //}

                    int index2 = ans.IndexOf(userAns[index]);
                    if (index2 >= 0)
                        if (index == index2)
                            aCount++;
                        else
                            bCount++;
                }
                result = string.Format("{0}A{1}B", aCount, bCount);

                Console.WriteLine(result);
            }
        }
    }
}