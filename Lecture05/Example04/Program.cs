using System;
using Example04.Models;


namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon()
            {
                Name = "妙蛙種子",
                Hp = 20
            };

            using (var context = new GameDbContext())
            {
                context.Pokemons.Add(pokemon);
                context.SaveChanges();
                Console.WriteLine("Done!");
            }
        }
    }
}
