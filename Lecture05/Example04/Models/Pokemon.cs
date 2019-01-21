using System;
using System.ComponentModel.DataAnnotations;

namespace Example04.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
    }
}