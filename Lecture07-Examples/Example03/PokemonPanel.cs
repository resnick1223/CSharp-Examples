using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonLibrary;

namespace Example03
{
    public partial class PokemonPanel : UserControl
    {
        public Pokemon pokemon;

        public PokemonPanel()
        {
            InitializeComponent();
            this.Font = new Font("微軟正黑體", 13.8F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));

            this.Margin = new Padding(5, 6, 5, 6);
            this.Size = new Size(260, 206);
            this.TabIndex = 2;
        }

        public void SetPokemon(Pokemon pokemon)
        {
            this.pokemon = pokemon;
            Render();
        }

        public void Render()
        {
            pokemonNameLabel.Text = this.pokemon.Name;
            pokemonHpLabel.Text = string.Format("HP:{0}", this.pokemon.Hp);
            pokemonCurrentHpLabel.Text = string.Format("Current HP:{0}", this.pokemon.CurrentHp);
        }

        private void pokemonNameLabel_Click(object sender, EventArgs e)
        {
            EditPokemonForm form = new EditPokemonForm();
            form.SetPokemonPanel(this);
            form.Show();
        }
    }
}