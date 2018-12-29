using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseballGame
{
    public class Umpire
    {
        public void Say(GameStatus gameStatus, BallStatus ballStatus)
        {
            MessageBox.Show(string.Format("{0}出局", gameStatus.Outs));
        }
    }
}