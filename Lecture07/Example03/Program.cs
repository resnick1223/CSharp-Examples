using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string json =
                @"
                    {
                        'dataset': {
                            'id':9775409
                        }
                    }";

            JObject data = JObject.Parse(json);
            Console.WriteLine((string)data["dataset"]["id"]);
        }
    }
}