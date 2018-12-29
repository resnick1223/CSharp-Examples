using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoopControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x0 = 5;
            int y0 = 5;
            int width = 100;
            int height = 100;
            int gutter = 5;
            int colCount = (this.Size.Width + gutter) / (width + gutter);

            for (int number = 0; number < 10; number++)
            {
                int row = number / colCount;
                int col = number % colCount == 0 ? 0 : number % colCount;
                int x = x0 + col * (width + gutter);
                int y = y0 + row * (height + gutter);
                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(x, y);
                pictureBox.Name = "pictureBox" + number.ToString();
                pictureBox.Size = new Size(width, height);
                pictureBox.TabIndex = 0;
                pictureBox.TabStop = false;
                pictureBox.BackColor = SystemColors.ActiveCaption;
                this.Controls.Add(pictureBox);
            }
        }
    }
}