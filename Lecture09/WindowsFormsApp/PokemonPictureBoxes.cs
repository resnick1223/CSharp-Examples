using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class PokemonPictureBoxes : UserControl
    {
        public int TotalPokemons { get; set; }

        public PokemonPictureBoxes()
        {
            InitializeComponent();
            this.button2.Click += new System.EventHandler(this.RemovePictureBoxes);
        }

        private void RemovePictureBoxes(object sender, EventArgs e)
        {
            foreach (var item in Controls.OfType<PictureBox>())
            {
                this.Controls.Remove(item);
            }
        }
    }
}