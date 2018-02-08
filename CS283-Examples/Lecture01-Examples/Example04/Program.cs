using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example1;

namespace Example04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();
            student.IsHappy = true;
            student.Age = null; ;

            if (student.IsHappy)
            {
                Console.WriteLine("我鬆了一口氣");
            }
            else
            {
                Console.WriteLine(@"
                    select * from table
                    where
                    ...
                    ");
            }
        }
    }
}