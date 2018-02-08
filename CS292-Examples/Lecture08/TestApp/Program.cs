using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(10);
            Console.Write("請選擇排序項目: (1) X, (2) Y, (3) Length");
            Vector.SortMode = SortingMode.ASC;
            Vector.CompareMode = (OrderBy)int.Parse(Console.ReadLine());
            Console.WriteLine("排序前:");
            Vector.WriteLine(vectors);
            Array.Sort(vectors);
            Console.WriteLine("排序後:");
            Vector.WriteLine(vectors);
        }
    }
}