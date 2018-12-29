using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Location = new System.Drawing.Point(57, 153);
            button.Name = "button1";
            button.Size = new System.Drawing.Size(175, 53);
            button.TabIndex = 0;
            button.Text = "這是new出來的按鈕";
            button.UseVisualStyleBackColor = true;
            this.Controls.Add(button);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            pic.Image = global::Example02.Properties.Resources._001;
            Random random = new Random();
            pic.Location = new System.Drawing.Point(random.Next(0, 300), random.Next(0, 300));
            pic.Name = "Pokemon";
            pic.Size = new System.Drawing.Size(121, 133);
            pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pic.TabIndex = 0;
            pic.TabStop = false;
            this.Controls.Add(pic);
        }
    }
}