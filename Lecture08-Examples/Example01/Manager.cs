using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Manager : Employee
    {
        public Manager()
        {
            Title = "經理";
        }

        public override int BaseSalary
        {
            get => base.BaseSalary;
            set
            {
                if (value < 61009)
                    baseSalary = 61009;
                else if (value > 90000)
                    baseSalary = 90000;
                else
                    baseSalary = value;
            }
        }
    }
}