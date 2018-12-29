using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRunLibrary
{
    public class LiveHeart : Props
    {
        public LiveHeart()
        {
            Name = "心型寶石";
        }

        public void AddPlayerHp()
        {
            player.HP += 10;
            player.CurrentHP = player.HP;
        }
    }
}