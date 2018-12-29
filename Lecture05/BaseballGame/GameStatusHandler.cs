using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballGame
{
    public delegate void GameStatusHandler(GameStatus gameStatus, BallStatus ballStatus);
}