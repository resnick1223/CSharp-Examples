using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonRunLibrary;

namespace PokemonRun
{
    public partial class GymBox : UserControl
    {
        private Pokemon pokemon;

        public GymBox()
        {
            InitializeComponent();
            pokemon = PokemonFactory.Create(4);

            this.pokemonBox.Render(pokemon);
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            GymScreen gym = new GymScreen();
            gym.Show();
            gym.Render(pokemon);
        }
    }
}