using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region 宣告變數

        private string pokemonName;
        private int pokemonCp;
        private int pokemonCurrentHp;
        private int pokemonMaxHp;
        private int pokemonPowerUpStardust;
        private int pokemonPowerUpCandy;

        private int playerStardust;
        private int playerCandy;

        private bool isPlayerCandyGtPokemonPowerUpCandy;

        private string playerInfoTextTemplate = "玩家的星塵 {0}, {1}糖果 {2}";

        #endregion 宣告變數

        public Form1()
        {
            InitializeComponent();

            #region 設定變數

            pokemonName = "閃電鳥";
            pokemonCp = 1860;
            pokemonCurrentHp = 114;
            pokemonMaxHp = 114;
            pokemonPowerUpStardust = 2500;
            pokemonPowerUpCandy = 2;

            playerStardust = 210000;
            playerCandy = 3;

            isPlayerCandyGtPokemonPowerUpCandy
               = playerCandy > pokemonPowerUpCandy;

            #endregion 設定變數

            // TODO 打開視窗的時候 要繪製畫面
            Render();
        }

        // TODO 強化按鈕 按下去了 要做什麼?
        private void powerUpButton_Click(object sender, EventArgs e)
        {
            // 玩家的糖果 = 本來的糖果 - 強化需要的糖果
            playerCandy = playerCandy - pokemonPowerUpCandy;
            playerStardust = playerStardust - pokemonPowerUpStardust;

            // TODO 重新 繪製畫面
            Render();
        }

        // TODO 重新 繪製畫面 的方法

        public void Render()
        {
            // FIXME 繪製 玩家資訊
            playerInfoLabel.Text = string.Format(playerInfoTextTemplate, playerStardust, pokemonName, playerCandy);

            // TODO 繪製 寶可夢資訊
            pokemonNameLabel.Text = string.Format(pokemonNameLabel.Text, pokemonName);

            // TODO 強化按鈕 根據 玩家星塵和糖果 是不是大於 閃電鳥的要求
            powerUpButton.Enabled = playerCandy >= pokemonPowerUpCandy;
        }
    }
}