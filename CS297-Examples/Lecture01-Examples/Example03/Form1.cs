using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            #region 變數宣告
            string pokemonName = "閃電鳥";
            int hp = 114;
            int maxHp = 114;
            float weight = 30.87f;
            float height = 1.18f;
            int playerStardust = 277396;
            int playerCandy = 3;
            int powerupStardust = 2500;
            int powerupCandy = 2;
            bool canPowerup =
                playerCandy >= powerupCandy &&
                playerStardust >= powerupStardust;
            #endregion
            string template =
                @"寶可夢 {0}
{1}/{2}HP,
{3}kg, {4}m
玩家的星星沙子{5}, {0}糖果{6}
強化需要星星沙子{7}, {0}糖果{8}
";
            richTextBox1.Text = string.Format(template,
      pokemonName,
         hp,
      maxHp,
        weight,
      height,
      playerStardust,
      playerCandy,
      powerupStardust,
      powerupCandy);
        }
    }
}
