using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonRunLibrary
{
    public class Player
    {
        public string Name;

        public List<Pokemon> Items;
        private EasyRandom random;

        // Step 3: 根據想要的機率 建立神奇數字
        private int[] magicNumbers = new int[] { 1, 3, 4 };

        public void Initialize()
        {
            Items = new List<Pokemon>();
            // Step 2: 初始亂數產生器
            random = new EasyRandom();
        }

        public bool Catch(Pokemon pokemon)
        {
            int number = random.Next(1, 7);
            bool catched = false;
            for (int index = 0; index < magicNumbers.Length; index++)
            {
                if (number == magicNumbers[index])
                {
                    catched = true;
                    this.Items.Add(pokemon);
                    break;
                }
            }

            return catched;
        }

        public void Print()
        {
            foreach (Pokemon p in Items)
            {
                Console.WriteLine(p.Name);
            }
        }
    }
}