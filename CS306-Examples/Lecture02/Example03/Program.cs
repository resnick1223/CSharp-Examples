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
            Console.Write("請輸入寶可夢的名稱: ");
            string pokemonName = Console.ReadLine();
            // 字串轉浮點數 parse convert
            Console.Write("請輸入寶可夢的身高: ");

            float pokemonHeight = 0.0f;
            try
            {
                pokemonHeight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("不好意思，請您重新檢查一下輸入的內容");
                return;
            }

            Console.WriteLine("您輸入的身高是{0}", pokemonHeight);

            Console.Write("請輸入寶可夢的體重: ");

            float pokemonWeight = 0.0f;
            try
            {
                pokemonWeight = float.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("不好意思，請您重新檢查一下輸入的內容");
                return;
            }

            Console.WriteLine("您輸入的身高是{0}", pokemonWeight);

            Console.Write("請輸入寶可夢的HP: ");

            int pokemonHP = 0;
            try
            {
                pokemonHP = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("不好意思，請您重新檢查一下輸入的內容");
                return;
            }

            Console.WriteLine("您輸入的身高是{0}", pokemonWeight);
        }
    }
}