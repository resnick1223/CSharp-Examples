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

namespace Example03
{
    public partial class EditPokemonForm : Form
    {
        public PokemonPanel panel;

        public EditPokemonForm()
        {
            InitializeComponent();
        }

        public void SetPokemonPanel(PokemonPanel panel)
        {
            this.panel = panel;
            Render();
        }

        public void Render()
        {
            nameTextBox.Text = panel.pokemon.Name;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.panel.pokemon.Name = nameTextBox.Text;
            this.panel.Render();
            this.Close();
        }
    }
}