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

namespace Example02
{
    public partial class Form1 : Form
    {
        private Pokemon pokemon;

        public Form1()
        {
            InitializeComponent();
            pokemon = PokemonFactory.Create(1);
            Render();
        }

        public void Render()
        {
            idLabel.Text = pokemon.Id.ToString();
            nameLabel.Text = pokemon.Name;
            heightLabel.Text = pokemon.Height.ToString();
            weightLabel.Text = pokemon.Weight.ToString();
        }

        private void pokemonComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = pokemonComboBox.Items[pokemonComboBox.SelectedIndex].ToString();
            pokemon = PokemonFactory.Create(int.Parse(id));
            Render();
        }
    }
}