using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example03
{
    public partial class MainWindow : Form
    {

        int seconds = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void travelButton_Click(object sender, EventArgs e)
        {
            this.scenePictureBox.Image = Example03.Properties.Resources.images;
            this.gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            Render();
        }

        private void Render()
        {
            if(seconds >= 5)
            {
                this.scenePictureBox.Image = Properties.Resources._7f910e537177f304383436c8067cbb17;
            }
        }
    }
}
