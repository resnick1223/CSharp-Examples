using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Render();
        }

        private void Render()
        {
            this.Controls.Clear();
            int xStart = 10;
            int yStart = 10;
            int width = 100;
            int height = 100;
            int marginX = 10;
            int marginY = 10;
            int cols = (this.Width - marginX) / (width + marginX);

            for (int index = 0; index < 10; index++)
            {
                int row = index / cols;
                int col = index % cols;
                int x = xStart + col * (width + marginX);
                int y = yStart + row * (height + marginY);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources._025;
                pictureBox.Location = new Point(x, y);
                pictureBox.Name = "pictureBox" + (index + 1);
                pictureBox.Size = new Size(width, height);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                this.Controls.Add(pictureBox);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Render();
        }
    }
}