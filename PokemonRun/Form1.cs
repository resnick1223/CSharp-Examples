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
    public partial class Form1 : Form
    {
        private GameController Game = new GameController();
        private List<Pokemon> pokemons = new List<Pokemon>();
        private int x;

        public Form1(int x)
        {
            this.x = x;
            InitializeComponent();
            Game.Initailize();
        }

        public Form1() : this(0)
        {
        }

        private void GeneratePokemonBox()
        {
            Pokemon pokemon = PokemonFactory.Generate();
            pokemons.Add(pokemon);
            PokemonBox pokemonBox = new PokemonBox(pokemon);
            pokemonBox.Render(this.Size);

            this.Controls.Add(pokemonBox);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pokemons.Count <= 5)
            {
                GeneratePokemonBox();
            }
        }

        private void pokemonBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("遇見野生的" + (sender as PictureBox).Name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}