using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Employee
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }

        public Employee()
        {
            Title = "行政助理";
            BaseSalary = 0;
        }

        protected int baseSalary;

        public virtual int BaseSalary
        {
            get => baseSalary;
            set
            {
                if (value < 21009)
                    baseSalary = 21009;
                else if (value > 50000)
                    baseSalary = 50000;
                else
                    baseSalary = value;
            }
        }

        public virtual int Salary
        {
            get => baseSalary;
        }

        public override string ToString()
        {
            return string.Format(
            "員工編號: {0}\n" +
            "員工姓名: {1}\n" +
            "職稱: {2}\n" +
            "底薪: {3}\n" +
            "總薪資: {4}"
            , Id
            , Name
            , Title
            , BaseSalary
            , Salary
            );
        }
    }
}