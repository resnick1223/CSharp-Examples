using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Sales : Employee
    {
        public int KPI { get; set; }

        public Sales()
        {
            Title = "業務";
        }

        public override int Salary
        {
            get
            {
                if (KPI < 4)
                {
                    return base.Salary;
                }
                else if (KPI >= 4 && KPI < 7)
                {
                    return base.Salary + 2000;
                }
                else if (KPI >= 7 && KPI < 9)
                {
                    return base.Salary + 5000 * KPI;
                }
                else
                {
                    return base.Salary + 10000 * KPI;
                }
            }
        }

        public override string ToString()
        {
            return
                base.ToString() +
                string.Format("\nKPI: {0}", KPI);
        }
    }
}