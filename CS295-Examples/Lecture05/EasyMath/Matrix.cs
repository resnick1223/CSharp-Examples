using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMath
{
    public class Matrix
    {
        public static void Print(int[] numbers)
        {
            foreach (int number in numbers)
                Console.WriteLine(number);
        }

        public static int Max(int[] numbers)
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                    max = number;
            }

            return max;
        }

        public static bool HasOne(int target, int[] numbers)
        {
            // 對於每一個number在numbers裡面
            foreach (int number in numbers)
            {
                if (number == target)
                    return true;
            }
            // 這個number是否等於 target
            // 如果 是 return true;
            // 如果 不是 return false;

            return false;
        }

        public static bool HasMany(int target, int[] numbers)
        {
            // 設定一個計數器 count = 0 從0開始
            int count = 0;
            // 對於每一個number在numbers裡面
            // 這個number是否等於 target
            foreach (int number in numbers)
            {
                if (number == target)
                    count++;
            }
            // 如果 是
            //    計數器 + 1
            if (count > 1)
                return true;
            //跳出迴圈後
            // 如果 計數器 > 1
            // return true;
            // 不是 return false;
            else
                return false;
        }

        public static int IndexOf(int target, int[] numbers)
        {
            // 先假設 position 在 -1
            int position = -1;

            // 從編號 0開始，找到陣列最後一號 (長度減1)
            for (int index = numbers.Length - 1; index >= 0; index--)
            {
                if (numbers[index] == target)
                {
                    position = index;
                    break;
                }
            }

            return position;
        }

        public static int Sum(int[] numbers)
        {
            int total = 0;
            foreach (int number in numbers)
                total += number;

            return total;
        }

        public static double Avg(int[] numbers)
        {
            return (double)Sum(numbers) / numbers.Length;
        }
    }
}