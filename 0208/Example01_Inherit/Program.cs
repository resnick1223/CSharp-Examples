using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace Example01_Inherit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee manager = new Manager();
            manager.Salary = 200000;
            Console.WriteLine(manager);
        }
    }
}