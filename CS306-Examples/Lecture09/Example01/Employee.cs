using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Employee
    {
        public string Name { get; set; }

        protected int salary;

        public virtual int Salary
        {
            get { return salary; }
            set
            {
                if (value > 50000)
                    salary = 50000;
                else if (value < 30000)
                    salary = 30000;
                else
                    salary = value;
            }
        }

        public virtual void Print()
        {
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return string.Format("員工姓名: {0}, 薪水: {1}", Name, Salary);
        }
    }
}
