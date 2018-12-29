using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace TestApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Manager someone = new Manager();
            Console.WriteLine(someone);
        }
    }
}