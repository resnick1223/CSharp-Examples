using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGoWinform
{
    public partial class MainWindow : Form
    {
        private int cp;
        private int currentHp;
        private int maxHp;
        private string name;
        private int userStardust;
        private int userPowerUpCandy;
        private int powerUpStardust;
        private int powerUpCandy;

        public MainWindow()
        {
            InitializeComponent();
            InitializeData();
            Render();
        }

        public void InitializeData()
        {
            name = "閃電鳥";
            cp = 1860;
            currentHp = 114;
            maxHp = 114;
            userStardust = 277396;
            userPowerUpCandy = 7;
            powerUpStardust = 2500;
            powerUpCandy = 2;
        }

        public void Render()
        {
            nameLabel.Text = name;
            cpLabel.Text = string.Format("CP {0}", cp);
            hpLabel.Text = string.Format("HP {0}/{1}", currentHp, maxHp);
            powerUpButton.Enabled =
                userPowerUpCandy > powerUpCandy
                && userStardust > powerUpStardust;
        }

        private void powerUpButton_Click(object sender, EventArgs e)
        {
            userStardust -= powerUpStardust;
            userPowerUpCandy -= powerUpCandy;
            maxHp += 10;
            currentHp += 10;
            cp += 40;
            Render();
        }
    }
}