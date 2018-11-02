using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "ABC";
            employee1.Salary = 35000;

            Employee employee2 = new Employee();
            employee2.Name = "DEF";
            employee2.Salary = 70000;

            Console.WriteLine(employee1.Salary);
            Console.WriteLine(employee2.Salary);
        }
    }
}