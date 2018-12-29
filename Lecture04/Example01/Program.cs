using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLibrary;

namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            string ratesString = Shell.Execute("python", @"C:\Users\Resnick\pyquery\crawler.py");

            string[] rates = ratesString.Split(' ');

            Print(rates, 4);
            
        }

        public static void Print(string[] data, int cols)
        {
            int rows =
                data.Length % cols == 0 ?
                data.Length / cols : data.Length / cols + 1;

            for (int row = 0; row < rows; row++)
            {
                int count = row == rows - 1 ? data.Length % cols : cols;
                for (int col = 0; col < count; col++)
                {
                    int index = row * cols + col;
                    Console.Write("{0} ", data[index]);
                }
                Console.WriteLine();
            }



        }

        public static string Max(string[] data)
        {
            string max = null;
            if (data.Length != 0)
                max = data[0];

            for (int index = 1; index < data.Length; index++)
            {
                string next = data[index];

                try
                {
                    if(double.Parse(next) > double.Parse(max))
                    {
                        max = next;
                    }
                }
                catch
                {
                    continue;
                }
                
            }

            return max;
        }
    }
}
