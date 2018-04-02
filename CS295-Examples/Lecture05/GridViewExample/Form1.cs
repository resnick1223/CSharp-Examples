using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Render2();
        }

        public void Render()
        {
            int totalPokemons = 17;
            int cols = 5;
            int rows = totalPokemons / cols + (totalPokemons % cols == 0 ? 0 : 1);
            int count = 1;
            for (int row = 1; row <= rows; row++)
            {
                int y = 0 + (row - 1) * 154;
                for (int col = 1; col <= cols; col++)
                {
                    int x = 0 + (col - 1) * 154;
                    Point location = new Point(x, y);
                    Size size = new Size(150, 150);
                    if (count <= totalPokemons)
                    {
                        CreatePokemonPictureBox(location, size);
                        count++;
                    }
                }
            }
        }

        public void CreatePokemonPictureBox(Point location, Size size)
        {
            PictureBox pictureBox = new PictureBox();

            pictureBox.Image = Properties.Resources._249;
            pictureBox.Location = location;
            pictureBox.Size = size;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(pictureBox);
        }

        public void Render2()
        {
            int totalPokemons = 17;
            int cols = 5;
            for (int count = 0; count < totalPokemons; count++)
            {
                int row = count / cols;
                int col = count % cols;
                int y = 0 + row * 154;
                int x = 0 + col * 154;
                Point location = new Point(x, y);
                Size size = new Size(150, 150);
                CreatePokemonPictureBox(location, size);
            }
        }
    }
}