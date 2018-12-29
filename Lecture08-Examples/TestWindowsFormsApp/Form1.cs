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

namespace TestWindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Pokemon pokemon1;
        private Pokemon pokemon2;

        public Form1()
        {
            InitializeComponent();
        }

        private void pokemon1Label_Click(object sender, EventArgs e)
        {
            pokemon2.Attack(pokemon1);
            Render();
        }

        private void pokemon2Label_Click(object sender, EventArgs e)
        {
            pokemon1.Attack(pokemon2);
            Render();
            if (pokemon2.Hp == 0)
            {
                gameTimer.Enabled = false;
                MessageBox.Show("恭喜你打贏" + pokemon2.Name);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            pokemon1 = PokemonFactory.Create(random.Next(1, 5));
            pokemon2 = PokemonFactory.Create(random.Next(1, 5));
            Render();
        }

        private void Render()
        {
            pokemon1Label.Text = string.Format("{0} HP:{1}", pokemon1.Name, pokemon1.Hp);
            pokemon2Label.Text = string.Format("{0} HP:{1}", pokemon2.Name, pokemon2.Hp);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pokemon2.Attack(pokemon1);
            Render();
        }
    }
}