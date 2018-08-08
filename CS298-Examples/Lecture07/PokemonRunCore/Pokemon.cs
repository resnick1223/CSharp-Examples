using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonRunCore
{
    public class Pokemon
    {
        #region 欄位

        private int nationalId;
        private int hp;
        private int maxHp;
        private int powerUpCandy;
        private int powerUpStardust;
        private static Random random;

        #endregion 欄位

        #region 屬性

        public string Name { get; set; }

        public int Hp
        {
            get => hp;
            set
            {
                this.hp = value < 0 ? 0 : value;
            }
        }

        public int MaxHp
        {
            get => maxHp;
            set
            {
                if (value < 0)
                    this.maxHp = 0;
                else if (value > 2500)
                    this.maxHp = 2500;
                else
                    this.maxHp = value;
            }
        }

        public int PowerUpCandy
        {
            get => powerUpCandy;
            set
            {
                this.powerUpCandy = value < 0 ? 0 : value;
            }
        }

        public int PowerUpStardust
        {
            get => powerUpStardust;
            set => powerUpStardust = value < 0 ? 0 : value;
        }

        public int NationalId
        {
            get => nationalId;
            set => nationalId = value < 0 ? 0 : value;
        }

        #endregion 屬性

        #region 建構式

        public Pokemon(int nationalId, string name)
        {
            if (Pokemon.random == null)
                Pokemon.random = new Random();
            this.Name = name;
            this.NationalId = nationalId;
            this.MaxHp = random.Next(10, 101);
            this.Hp = MaxHp;
            this.PowerUpCandy = 2;
            this.PowerUpStardust = 2500;
        }

        public Pokemon(
            int nationalId,
            string name,
            int hp,
            int maxHp,
            int powerUpCandy,
            int powerUpStardust,
            Random random)
            : this(nationalId, name)
        {
            this.Hp = hp;
            this.MaxHp = maxHp;
            this.PowerUpCandy = powerUpCandy;
            this.PowerUpStardust = powerUpStardust;
        }

        #endregion 建構式

        public override string ToString()
        {
            return string.Format("寶可夢 名稱:{0}, HP{1}/{2}, 進化需要 {0}糖果:{3}, 星塵:{4}"
                , Name, Hp, MaxHp, PowerUpCandy, PowerUpStardust);
        }

        public static Pokemon Generate(int nationalId, string name)
        {
            return new Pokemon(nationalId, name);
        }

        public static Pokemon[] Generate(int nationalId, string name, int count)
        {
            Pokemon[] pokemons = new Pokemon[count];
            for (int index = 0; index < count; index++)
                pokemons[index] = Pokemon.Generate(nationalId, name);

            return pokemons;
        }

        public static void WriteLine(Pokemon[] pokemons)
        {
            foreach (Pokemon pokemon in pokemons)
                Console.WriteLine(pokemon);
        }
    }
}