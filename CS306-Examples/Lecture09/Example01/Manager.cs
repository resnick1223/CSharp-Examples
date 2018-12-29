using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Manager : Employee
    {

        public int Performance { get; set; }
        public override int Salary {
            get => base.Salary;
            set
            {
                if (value > 100000)
                    salary = 100000;
                else if (value < 50000)
                    salary = 50000;
                else
                    salary = value;
            }
        }

        public new void Print()
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Override的版本");
            base.Print();
        }

        public override string ToString()
        {
            return "主管:\n" + base.ToString();
        }
    }
}
