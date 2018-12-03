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
    public partial class Form1 : Form
    {
        private bool isPlaying;

        // 建構式
        public Form1()
        {
            InitializeComponent();
            isPlaying = false;
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            NumberTimer.Enabled = !NumberTimer.Enabled;
            this.isPlaying = NumberTimer.Enabled;
            PlayButton.Text = this.isPlaying ? "Stop" : "Play";
        }

        private void NumberTimer_Tick(object sender, EventArgs e)
        {
            int currentNumber = int.Parse(NumberLabel.Text);
            NumberLabel.Text = (++currentNumber).ToString();
        }
    }
}