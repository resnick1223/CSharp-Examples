using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonLibrary
{
    public abstract class Pokemon
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Hp { get; set; }
        public int CurrentHp { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public int Cp;
        protected static Random random;

        public int PowerUpCandy { get; set; }
        public int EvolveCandy { get; set; }

        public Pokemon()
        {
            if (Pokemon.random == null)
                Pokemon.random = new Random();
        }

        public override string ToString()
        {
            string str = base.ToString() + "\n";
            str += string.Format("Pokemon id:{0}, Name:{1}, Height:{2}, Weight:{3}", Id, Name, Height, Weight);
            return str;
        }
    }
}