using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameRunLibrary;

namespace GameRun
{
    public partial class MainWindow : Form
    {
        public bool pressW = false;
        private int walkCount = 0;
        private Player player = new PlayerOne();
        private int backgroundType = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'w' || e.KeyChar == 'W') && walkCount < 20)
            {
                string walkType = player.playerWalk();

                CharacterBox.Image = (Image)Properties.Resources.ResourceManager.GetObject("walk" + walkType);
                if (backgroundType < 6)
                {
                    this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("Back" + backgroundType);
                    backgroundType++;
                }
                else if (backgroundType >= 6)
                {
                    this.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject("Back6");
                    backgroundType = 0;
                }

                walkCount++;
            }
            else if (walkCount >= 20)
            {
                開寶 開寶 = new 開寶();
                開寶.Show();
                walkCount = 0;
            }
        }
    }
}