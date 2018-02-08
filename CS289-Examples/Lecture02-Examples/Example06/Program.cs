using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[4];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;

            string student1Name = "A";
            string student1Phone = "0912345678";

            string student2Name = "B";
            string student2Phone = "0987654321";

            string[] names = new string[] { "A", "B" };
            string[] phones = new string[] { "0912345678", "0987654321" };

            Student student1 = new Student()
            {
                Name = "A",
                Phone = "0912345678"
            };

            Console.WriteLine(student1.Name);
        }
    }
}