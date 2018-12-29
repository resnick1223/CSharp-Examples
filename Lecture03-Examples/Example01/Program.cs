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
            Calculator iphone = new Calculator();
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 3;
            numbers[2] = 19;

            //numbers = new int[] { 1, 3, 19 };
            int result = iphone.Sum(numbers);
            Console.WriteLine(result);
        }
    }
}