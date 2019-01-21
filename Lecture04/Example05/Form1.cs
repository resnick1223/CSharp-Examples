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
            Controls.Clear();

            for (int number = 0; number < 10; number++)
            {
                int width = 100;
                int xGap = 5;
                int height = 100;
                int yGap = 5;
                int xStart = 10;
                int yStart = 10;
                int numberOfCol = (this.Width - 2 * xGap) / (width + xGap);
                int row = number / numberOfCol;
                int col = number % numberOfCol;

                int x = xStart + col * (width + xGap);
                int y = yStart + row * (height + yGap);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Properties.Resources._001;
                pictureBox.Location = new Point(x, y);
                pictureBox.Name = "pictureBox" + number;
                pictureBox.Size = new Size(width, height);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.TabIndex = number;
                pictureBox.TabStop = false;
                Controls.Add(pictureBox);
                ((System.ComponentModel.ISupportInitialize)(pictureBox)).EndInit();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Render();
        }
    }
}