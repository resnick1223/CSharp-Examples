using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMath.NET;

namespace PokemonLibrary
{
    public class Bulbasaur : Pokemon
    {
        public Bulbasaur() : base()
        {
            NationalNo = 1;
            Name = "妙蛙種子";

            Cp = 200;
            Iv = random.Next(60, 101);
            if (Iv >= 60 && Iv < 70)
                Cp += random.Next(-10, 11);
            else if (Iv >= 70 && Iv < 80)
                Cp += random.Next(10, 21);
            else if (Iv >= 80 && Iv < 90)
                Cp += random.Next(20, 31);
            else
                Cp += random.Next(30, 51);

            MaxHp = 45;
            MaxHp += random.Next(0, 11);
            CurrentHp = MaxHp;

            Height = 0.71f;

            Weight = 6.9f;

            PowerUpStardust = 2500;
            PowerUpCandy = 3;
        }

        public override float Height
        {
            get => base.Height;
            set
            {
                height = value;
                height += (float)random.NextDouble(-0.1, 1.5);
            }
        }

        public override float Weight
        {
            get => base.Weight;
            set
            {
                weight = value;
                weight += (float)random.NextDouble(-2.5, 2.6);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}