using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;


namespace Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon()
            {
                NationalNo = 1,
                Name = "妙蛙種子"
            };

            JObject pokemonJSON = new JObject();
            pokemonJSON["Name"] = "妙蛙種子";
           
            
            Console.WriteLine(pokemonJSON.ToString());
        }
    }
}
