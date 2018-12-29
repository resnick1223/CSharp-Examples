using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string email = "resnick1223@gmail.com";
            Console.WriteLine(email.IndexOf("b"));
            Console.WriteLine(email[11]);
        }
    }
}