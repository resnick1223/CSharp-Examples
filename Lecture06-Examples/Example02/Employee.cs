using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    public class Employee
    {
        public string Name;
        private int baseSalary;
        private int benefit;

        public int BaseSalary
        {
            get => baseSalary;
            set => baseSalary = value < 0 ? 0 : value;
        }

        public int Benefit
        {
            get => benefit;
            set => benefit = value < 0 ? 0 : value;
        }

        public int Salary
        {
            get { return BaseSalary + Benefit; }
        }
    }
}