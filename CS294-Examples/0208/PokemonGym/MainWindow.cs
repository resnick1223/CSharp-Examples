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

namespace PokemonGym
{
    public partial class MainWindow : Form
    {
        private int[] nationalNos;
        private Random random;
        private int nationalNo1;
        private int nationalNo2;
        private Pokemon pokemon1;
        private Pokemon pokemon2;

        public MainWindow()
        {
            InitializeComponent();

            nationalNos = new int[] { 1, 2, 25 };
            random = new Random();
            nationalNo1 = nationalNos[random.Next(0, nationalNos.Length)];
            nationalNo2 = nationalNos[random.Next(0, nationalNos.Length)];
            pokemon1 = PokemonFactory.Create(nationalNo1);
            pokemon2 = PokemonFactory.Create(nationalNo2);
            pokemon1.nationalNo = nationalNo1;
            pokemon2.nationalNo = nationalNo2;
            Render();
        }

        private void Render()
        {
            pokemon1PictureBox.Image =
                (Image)Properties
                .Resources
                .ResourceManager
                .GetObject(pokemon1.GetResourceNumber());
            pokemon2PictureBox.Image =
                (Image)Properties
                .Resources
                .ResourceManager
                .GetObject(pokemon2.GetResourceNumber());

            pokemon1HpLabel.Text
                = string.Format("HP: {0}/{1}", pokemon1.CurrentHp, pokemon1.maxHp);
            pokemon2HpLabel.Text
                = string.Format("HP: {0}/{1}", pokemon2.CurrentHp, pokemon2.maxHp);
            pokemon1HpProgressBar.Maximum = pokemon1.maxHp;
            pokemon1HpProgressBar.Value = pokemon1.CurrentHp;

            if (pokemon2.CurrentHp == 0 && pokemon1.CurrentHp > 0)
            {
                MessageBox.Show("你贏了");
                gameTimer.Enabled = false;
                return;
            }

            if (pokemon1.CurrentHp == 0 && pokemon2.CurrentHp > 0)
            {
                MessageBox.Show("QQ了");
                gameTimer.Enabled = false;
                return;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            pokemon2.Attack(pokemon1);
            Render();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            gameTimer.Enabled = true;
        }

        private void pokemon2PictureBox_Click(object sender, EventArgs e)
        {
            pokemon1.Attack(pokemon2);
            Render();
        }
    }
}