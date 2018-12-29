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
            Console.Write("1+2+3....+??: 請輸入??:");
            int end = int.Parse(Console.ReadLine());

            int total = 0;
            string result = "";
            for (int number = 1; number <= end; number++)
            {
                total = total + number;
                if (number < 6)
                    result = result + string.Format("{0} + ", number);
                else if (number >= 6 && number < end)
                {
                    result = result + string.Format("... + ");
                }
                else
                    result = result + string.Format("{0} = {1}", number, total);
            }

            Console.WriteLine(result);
        }
    }
}