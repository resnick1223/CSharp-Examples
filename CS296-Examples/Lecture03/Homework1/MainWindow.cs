using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class MainWindow : Form
    {
        private int powerUpCandy = 2;
        private int userPowerUpCandy = 3;

        public MainWindow()
        {
            InitializeComponent();
            Render();
        }

        public void Render()
        {
            PowerUpButton.Enabled = userPowerUpCandy >= powerUpCandy;
        }

        private void PowerUpButton_Click(object sender, EventArgs e)
        {
        }
    }
}