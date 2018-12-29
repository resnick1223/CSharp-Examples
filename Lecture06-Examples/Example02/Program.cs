using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Vector[] vectors = Vector.Generate(3, -20, 20);

            Console.WriteLine("排序前:");
            foreach (Vector v in vectors)
                v.Print();
            Console.Write("請選擇排序欄位: (1) X, (2) Y, (3) Length");
            int orderBy = int.Parse(Console.ReadLine());
            if (orderBy == 1)
                Vector.OrderByField = OrderBy.X;
            else if (orderBy == 2)
                Vector.OrderByField = OrderBy.Y;
            else
                Vector.OrderByField = OrderBy.Length;

            Array.Sort(vectors);
            Console.WriteLine("排序後:");
            foreach (Vector v in vectors)
                v.Print();
        }
    }
}