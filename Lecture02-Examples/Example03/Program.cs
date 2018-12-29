using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GpaConvertor c = new GpaConvertor();

            Console.WriteLine(c.Convert(93));
            Console.WriteLine(c.Convert(87));
        }
    }
}