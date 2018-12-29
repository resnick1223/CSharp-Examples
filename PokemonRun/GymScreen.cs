using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonRunLibrary;

namespace PokemonRun
{
    public partial class GymScreen : Form
    {
        private Pokemon pokemon1;
        private Pokemon pokemon2;

        public GymScreen()
        {
            InitializeComponent();
        }

        public void Render(Pokemon pokemon)
        {
            this.pokemon1 = pokemon;
            this.pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon.ImageFileName);
            this.pokemon2 = PokemonFactory.Create(2);
            this.hpLabel.Text = "HP: " + pokemon1.CurrentHP.ToString();
            this.pictureBox2.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon2.ImageFileName);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pokemon2.Attack(pokemon1);
            this.hpLabel.Text = "HP: " + pokemon1.CurrentHP.ToString();
            if (pokemon1.CurrentHP <= 0 || pokemon2.CurrentHP <= 0)
            {
                gymTimer.Enabled = false;
                if (pokemon2.CurrentHP > pokemon1.CurrentHP)
                    MessageBox.Show("恭喜你戰勝" + pokemon1.Name);
                else
                    MessageBox.Show("很可惜，挑戰失敗");
            }
        }

        private void gymTimer_Tick(object sender, EventArgs e)
        {
            pokemon1.Attack(pokemon2);
            this.pokemon2HpLabel.Text = "HP: " + pokemon2.CurrentHP.ToString();

            if (pokemon2.CurrentHP <= 0)
            {
                MessageBox.Show("很可惜，挑戰失敗");
                gymTimer.Enabled = false;
            }
        }
    }
}