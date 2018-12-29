using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            員工 某個員工 = new 空服員()
            {
                姓名 = "帽子哥",
                薪水 = 22000,
                飛行時數 = 10
            };

            某個員工.列印薪資單();
        }
    }
}