using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            JObject pokemon = new JObject();
            pokemon["Name"] = "妙蛙種子";
            Console.WriteLine(pokemon);

            string pokemonJson =
                @"{'Name':'妙蛙草'}";
            JObject pokemon2 = JObject.Parse(pokemonJson);
            Console.WriteLine(pokemon2);

            JArray array = new JArray();
            array.Add("Manual text");
            array.Add(new DateTime(2000, 5, 23));

            JObject o = new JObject();
            o["MyArray"] = array;

            Console.WriteLine(o);
            // {
            //   "MyArray": [
            //     "Manual text",
            //     "2000-05-23T00:00:00"
            //   ]
            // }
        }
    }
}