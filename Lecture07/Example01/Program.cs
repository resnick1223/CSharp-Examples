using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;
namespace Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee someone = new Employee();
            int value = int.Parse(Console.ReadLine());
            someone.Salary = value;
            Console.WriteLine(someone.Salary);
        }
    }
}
