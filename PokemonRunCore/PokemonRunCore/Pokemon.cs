using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRunCore
{
    public class Pokemon
    {
        public string name;
        public int nationalNo;
        private int iv;
        public int cp;
        public int maxHp;
        private int hp;

        public int Hp
        {
            get
            {
                return this.hp;
            }

            set
            {
                if (value > 300)
                    this.hp = 300;
                else if (value < 0)
                    this.hp = 0;
                else
                    this.hp = value;
            }
        }

        /// <summary>
        /// 寶可夢的建構式
        /// </summary>
        /// <param name="nationalNo">編號</param>
        /// <param name="name"></param>
        /// <param name="maxHp"></param>
        public Pokemon(int nationalNo, string name, int maxHp)
        {
            this.nationalNo = nationalNo;
            this.name = name;
            this.maxHp = maxHp;
            this.hp = this.maxHp;
            Random random = new Random();
            switch (this.nationalNo)
            {
                case 1:
                    this.cp = random.Next(50, 101);
                    this.iv = this.nationalNo * cp * random.Next(1, 4);
                    break;

                case 2:
                    this.cp = random.Next(50, 101);
                    this.iv = this.nationalNo * cp * random.Next(1, 4);
                    break;

                default:
                    this.cp = random.Next(10, 51);
                    this.iv = this.nationalNo * cp;
                    break;
            }
        }

        public Pokemon() : this(1, "妙蛙種子", 110)
        {
        }

        public void DisplayInfo()
        {
            Console.WriteLine("National NO: {0}", this.nationalNo);
            Console.WriteLine("Name: {0}", this.name);
            Console.WriteLine("HP: {0}/{1}", this.hp, this.maxHp);
            Console.WriteLine("CP: {0}", this.cp);
        }

        public void RestoreHp()
        {
            this.hp = this.maxHp;
        }

        public void Attack(Pokemon other)
        {
            other.Hp -= 15;
        }
    }
}