using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;

namespace Example05
{
    public partial class MainWindow : Form
    {
        public Pokemon pokemon;

        public MainWindow()
        {
            InitializeComponent();

            pokemon = new Pokemon()
            {
                name = "妙蛙種子",
                hp = 20
            };

            // 呼叫繪製視窗的函式
            Render();
        }

        private void PokemonPowerUpButton_Click(object sender, EventArgs e)
        {
            pokemon.hp += 10;

            // 呼叫繪製視窗的函式
            Render();
        }

        // 繪製視窗的函式
        private void Render()
        {
            //負責修改Label

            PokemonNameLabel.Text = string.Format("寶可夢名稱: {0}", pokemon.name);
            PokemonHPLabel.Text = string.Format("寶可夢HP: {0}", pokemon.hp);
        }
    }
}