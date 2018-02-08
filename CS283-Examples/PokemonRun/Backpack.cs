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
    public partial class Backpack : Form
    {
        private int gutter = 12;
        private int pokemonBoxWidth = 150;
        private int numberOfColumn;
        private List<PokemonBox> pokemonBoxes;
        private List<Pokemon> pokemons;
        private Point start = new Point(12, 12);

        public Backpack()
        {
            InitializeComponent();

            pokemons = PokemonFactory.Generate(14);
            pokemonBoxes = new List<PokemonBox>();

            numberOfColumn = (this.Width - gutter) / (pokemonBoxWidth + gutter);
            for (int index = 0; index < pokemons.Count; index++)
            {
                PokemonBox pokemonBox = new PokemonBox(PokemonFactory.Generate());

                pokemonBox.Render(this.Size);
                pokemonBox.Size = new Size(150, 180);
                int x = start.X + (index % numberOfColumn) * (pokemonBox.Width + gutter);
                int y = start.Y + (index / numberOfColumn) * (pokemonBox.Height + gutter);
                pokemonBox.Location = new Point(x, y);
                this.Controls.Add(pokemonBox);
                pokemonBoxes.Add(pokemonBox);
            }
        }

        private void Backpack_Resize(object sender, EventArgs e)
        {
            numberOfColumn = (this.Width - gutter) / (pokemonBoxWidth + gutter);
            for (int index = 0; index < pokemons.Count; index++)
            {
                int x = start.X + (index % numberOfColumn) * (pokemonBoxes[index].Width + gutter);
                int y = start.Y + (index / numberOfColumn) * (pokemonBoxes[index].Height + gutter);
                pokemonBoxes[index].Location = new Point(x, y);
            }
        }
    }
}