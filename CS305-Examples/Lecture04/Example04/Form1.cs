using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example04
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
            int x0 = 3;
            int y0 = 3;
            int w = 100;
            int h = 100;
            int dw = 10;
            int dh = 20;
            int cols = (this.Width + dw) / (w + dw);

            for (int number = 0; number < 10; number++)
            {
                // row = 編號 / 一排幾個 得到的商
                int row = number / cols;
                int col = number % cols;

                int x = col * (w + dw) + x0;
                int y = row * (h + dh) + y0;

                PictureBox pictureBox = new PictureBox();
                ((ISupportInitialize)(pictureBox)).BeginInit();
                this.SuspendLayout();

                pictureBox.Image = Properties.Resources.Zapdos;
                pictureBox.Location = new Point(x, y);
                pictureBox.Name = "pictureBox1";
                pictureBox.Size = new Size(w, h);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.TabIndex = 0;
                pictureBox.TabStop = false;
                this.Controls.Add(pictureBox);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Render();
        }
    }
}