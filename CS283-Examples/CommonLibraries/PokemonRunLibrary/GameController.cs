using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMathLibrary;

namespace PokemonRunLibrary
{
    public class GameController
    {
        public Player player;

        #region 初始化設定遊戲

        public void Initailize()
        {
            // Step 4: 建立一個玩家的物件
            player = new Player();
            player.Initialize();
        }

        #endregion 初始化設定遊戲

        public void StartConsole()
        {
            Initailize();
            Pokemon p = PokemonFactory.Generate();
            Console.WriteLine("遇到野生的{0}", p.Name);
            Console.WriteLine("開始戰鬥，丟出寶貝球");

            if (player.Catch(p))
            {
                Console.WriteLine("抓到野生的{0}", p.Name);
            }
            else
            {
                Console.WriteLine("好可惜，{0}逃走了", p.Name);
            }
        }
    }
}