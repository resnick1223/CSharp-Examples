using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.hp = 10;
            pokemon.maxHp = 30;
            Student student = new Student()
            {
                id = "1",
                birthday = DateTime.Now,
                name = "帽子哥"
            };
        }
    }
}