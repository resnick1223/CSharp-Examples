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
        private int hp;
        private MainWindow subwindow;

        public int Hp
        {
            get => hp;
            set => hp = value;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void createNewWindowButton_Click(object sender, EventArgs e)
        {
            this.subwindow = new MainWindow();
            subwindow.Text = "這是被產生的子視窗";
            subwindow.Show();
        }

        private void changeHpButton_Click(object sender, EventArgs e)
        {
            this.subwindow.Hp = 100;
            this.subwindow.hpLabel.Text = this.subwindow.Hp.ToString();
        }
    }
}