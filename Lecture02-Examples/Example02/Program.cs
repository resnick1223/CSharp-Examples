using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentLibrary;
using PokemonRunLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = new int[] { 90, 9, 8, 10 };
            //numbers[0] = 90;
            //numbers[1] = 9;
            //numbers[2] = 8;
            //numbers[3] = 10;

            Student[] students = new Student[3];
            students[0] = new Student()
            {
                Name = "A同學"
            };
            students[1] = new Student()
            {
                Name = "B同學"
            };
            students[2] = new Student()
            {
                Name = "C同學"
            };

            Console.WriteLine(students[0].Name);
            Console.WriteLine(students[1].Name);
            Console.WriteLine(students[2].Name);
            Console.WriteLine(students.Length);

            Team aTeam = new Team();
            aTeam.Members = new List<Pokemon>();
            aTeam.Members.Add(new Pokemon() { Name = "小火龍" });
            aTeam.Members.Add(new Pokemon() { Name = "妙蛙種子" });
            aTeam.Members.Add(new Pokemon() { Name = "妙蛙種子" });
            Console.WriteLine(aTeam.Members[0].Name);
            Console.WriteLine(aTeam.Members[1].Name);
            Console.WriteLine(aTeam.Members[2].Name);
            Console.WriteLine(aTeam.Members.Count);
        }
    }
}