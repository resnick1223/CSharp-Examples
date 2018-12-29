using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        public override int Salary
        {
            get => base.Salary;
            set
            {
                if (value > 100000)
                {
                    this.salary = 100000;
                }
                else if (value < 50000)
                {
                    this.salary = 50000;
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public void Print()
        {
        }
    }
}