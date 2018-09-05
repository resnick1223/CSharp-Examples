using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PyShellLibrary;
using Newtonsoft.Json.Linq;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string pyFilePath = @"C:\Users\resnick\crawler-for-csharp\crawler.py";
            string jsonString = PyShell.Exec(pyFilePath);
            JObject rates = JObject.Parse(jsonString);

            Console.WriteLine(rates["JPY"]);
        }
    }
}