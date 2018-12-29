using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example07
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                ChineseName = "帽子哥",
                Name = "Yuan Hung Chang",
                Birthday = "1223",
                HomeAddress = "..."
            };

            Student student2 = new Student()
            {
                ChineseName = "帽子哥",
                Name = "Yuan Hung Chang",
                Birthday = "1223",
                HomeAddress = "..."
            };

            Console.WriteLine(student1.Name);
        }
    }
}