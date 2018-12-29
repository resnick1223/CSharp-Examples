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
    public partial class MainWindow : Form
    {
        private string PokemonName = "閃電鳥";
        private int PokemonCP = 1860;
        private int PokemonHP = 114;
        private int PokemonMaxHP = 114;
        private double PokemonHeight = 1.18;
        private double PokemonWeight = 30.87;
        private string[] PokemonTypes = new string[] { "電", "飛行" };
        private int PlayerStardust = 277396;
        private int PlayerCandy = 3;
        private int PokemonPowerUpStardust = 2500;
        private int PokemonPowerUpCandy = 2;

        public MainWindow()
        {
            InitializeComponent();
            Render();
        }

        private void Render()
        {
            PokemonCPLabel.Text = string.Format("CP: {0}", PokemonCP);
            PokemonNameLabel.Text = string.Format("名稱: {0}", PokemonName);
            PokemonHPLabel.Text = string.Format("HP: {0}/{1}", PokemonHP, PokemonMaxHP);
            PokemonHeightLabel.Text = string.Format("身高: {0}m", PokemonHeight);
            PokemonWeightLabel.Text = string.Format("體重: {0}kg", PokemonWeight);
            PlayerStardustLabel.Text = string.Format("星星沙子: {0}", PlayerStardust);
            PlayerCandyLabel.Text = string.Format("寶可夢糖果: {0}", PlayerCandy);
            PokemonTypeLabel.Text = string.Format("{0}, {1}", PokemonTypes[0], PokemonTypes[1]);
            PowerUpNeedsLabel.Text = string.Format("星星沙子: {0}, 寶可夢糖果: {1}", PokemonPowerUpStardust, PokemonPowerUpCandy);
            PowerUpButton.Enabled = PlayerCandy >= PokemonPowerUpCandy && PlayerStardust >= PokemonPowerUpStardust;
        }

        private void PowerUpButton_Click(object sender, EventArgs e)
        {
            PlayerStardust -= PokemonPowerUpStardust;
            PlayerCandy -= PokemonPowerUpCandy;
            Render();
        }
    }
}