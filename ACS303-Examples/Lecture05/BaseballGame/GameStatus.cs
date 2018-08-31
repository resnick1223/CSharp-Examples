using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public class GameStatus : EventArgs
    {
        public int Strikes { get; set; }
        public int Outs { get; set; }
    }
}