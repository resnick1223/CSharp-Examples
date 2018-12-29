using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonRun;

namespace PokemonRunWinForm
{
    public partial class MainWindow : Form
    {

        寶可夢 寶可夢1;
        寶可夢 寶可夢2;

        public MainWindow()
        {
            Random 亂數產生器 = new Random();
            int 編號1 = 亂數產生器.Next(1, 5);
            int 編號2 = 亂數產生器.Next(1, 5);

            InitializeComponent();
            寶可夢1 = 寶可夢工廠.創建(編號1);
            寶可夢2 = 寶可夢工廠.創建(編號2);
            寶可夢區塊1.繪製畫面(寶可夢1);
            寶可夢區塊2.繪製畫面(寶可夢2);
        }

        private void 寶可夢區塊1_Click(object sender, EventArgs e)
        {
            寶可夢2.攻擊(寶可夢1);
            寶可夢區塊1.繪製畫面(寶可夢1);
        }

        private void 遊戲計時器_Tick(object sender, EventArgs e)
        {
            寶可夢2.攻擊(寶可夢1);
            寶可夢區塊1.繪製畫面(寶可夢1);
        }

        private void 寶可夢區塊2_Click(object sender, EventArgs e)
        {
            寶可夢1.攻擊(寶可夢2);
            寶可夢區塊2.繪製畫面(寶可夢2);
        }
    }
}
