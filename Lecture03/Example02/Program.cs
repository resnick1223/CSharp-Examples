using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;
using MyToolbox;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = Faker.FindStudents(10);
            Student.WriteLine(students);
        }
    }
}