using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Camera iphone7 = new Camera();
            Console.WriteLine(iphone7.GetImage());
            iphone7.plugin = new LomoFilter();
            Console.WriteLine(iphone7.GetImage());
            iphone7.plugin = null;
            Console.WriteLine(iphone7.GetImage());
            iphone7.plugin = new BeautifyFacePlugin();
            Console.WriteLine(iphone7.GetImage());
            iphone7.plugin = null;
            Console.WriteLine(iphone7.GetImage());
        }
    }
}