using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public enum EmployeeType
    {
        Default = 1, Manager, Sales, TopSales
    }

    public class EmployeeFactory
    {
        public static Employee Create(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Default:
                    return new Employee();

                case EmployeeType.Manager:
                    return new Manager();

                case EmployeeType.Sales:
                    return new Sales();

                case EmployeeType.TopSales:
                    return new TopSales();

                default:
                    return new Employee();
            }
        }
    }
}