using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyGameEngine;

namespace WindowsFormsApp
{
    public partial class MainWindow : Form
    {
        private Pokemon pokemon;
        private double step;
        private double distance;
        private double difference;

        public MainWindow()
        {
            InitializeComponent();
            this.pokemon = new Pokemon();
            this.pokemon.nationalNo = 120;
            this.pokemon.theta = 0.0;
            this.pokemon.pos.x = pokemonPictureBox.Location.X;
            this.pokemon.pos.y = pokemonPictureBox.Location.Y;
            Render();
        }

        public void Render()
        {
            pokemonPictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pokemon.GetResourceNumber());
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            double distance = 0.0;
            bool convertible = double.TryParse(distanceTextBox.Text, out distance);
            if (!convertible)
            {
                MessageBox.Show("請重新輸入移動距離");
                return;
            }
            this.distance = distance;
            this.step = distance * ((double)this.gameTimer.Interval) / 1000.0;
            this.gameTimer.Enabled = true;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pokemon.MoveForward(this.step);
            this.difference += step;
            int x = (int)pokemon.pos.x;
            int y = (int)pokemon.pos.y;
            pokemonPictureBox.Location = new Point(x, y);
            Render();
            if (Math.Abs(this.difference - this.distance) < 1E-5)
            {
                this.gameTimer.Enabled = false;
                this.difference = 0.0;
            }
        }
    }
}