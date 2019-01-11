using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = new Student[3]
            {
                new Student{ Id = 1, Name = "a"},
                new Student{ Id = 2, Name = "b"},
                new Student{ Id = 3, Name = "c"}
            };
        }
    }
}