using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 冒險遊戲
{
    public partial class MainForm : Form
    {
        private int Times = 30;
        private int Hp = 100;
        private Random random = new Random(4);
        private int[] a = new int[4] { 2, -3, -4, 5 };
        private int i;

        public MainForm()
        {
            InitializeComponent();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(Environment.ExitCode);

            InitializeComponent();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            HpLabel.Text = "HP: " + Hp;
            TimeLabel.Text = "前進30次後結束";
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (Box.MaxLength == 15)
            {
                Box.Text = "";
            }
            Times--;
            {
                TimeLabel.Text = "前進" + Times + "次後結束";

                HpLabel.Text = "Hp: " + Hp + a[i];
            }
            if (Times == 0)
                MessageBox.Show("過關啦~~~");
            if (HpLabel.Text == "" + 0)
                MessageBox.Show("結束了~~~");
        }

        private void Box_TextChanged(object sender, EventArgs e)
        {
            a[random.Next(4) = a[0]];
            Box.Text = "你找到食物啦!回復2滴血";
            a[random.Next(4) == a[1]];
            Box.Text = "你碰到落石囉!!減少3滴血";
            a[random.Next(4)] == a[2];
            Box.Text = "你遇到毒蛇囉!減少4滴血";
            a[random.Next(4)] == a[3];
            Box.Text = "你找到食物啦!回復5滴血";
        }
    }
}