using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath.NET;

namespace PokemonLibrary
{
    public class Ivysaur : Bulbasaur
    {
        public Ivysaur() : base()
        {
            NationalNo = 2;
            Name = "妙蛙草";
            Height = 1.2f;
            CurrentHp = MaxHp;
        }

        public override float Height
        {
            get => base.Height;
            set
            {
                base.Height = value;
                height += random.Next(100, 201);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}