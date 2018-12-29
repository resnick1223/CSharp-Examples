using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShellLibrary;

namespace Example02
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = Shell.Execute("python", @"C:\Users\Resnick\pyquery\crawler.py");
            Console.WriteLine(result);
        }

        
    }
}
