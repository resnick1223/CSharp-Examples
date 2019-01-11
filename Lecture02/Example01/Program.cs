using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "帽子哥"
            };
            Console.WriteLine(student.Name);
        }
    }
}