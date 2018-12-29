using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee employee = null;
            if (args.Length <= 0)
            {
                employee = EmployeeFactory.Create(EmployeeType.Default);
            }
            else

            {
                EmployeeType type = (EmployeeType)int.Parse(args[0]);
                employee = EmployeeFactory.Create(type);
            }

            Console.WriteLine(employee);
        }
    }
}