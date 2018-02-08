using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int com = 0;
        private Random random = new Random();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txt1.ReadOnly = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            com = random.Next(1, 4);
            if (com == 1)
                txt1.Text = "電腦出剪刀,平手了";
            else if (com == 2)
                txt1.Text = "電腦出石頭,你輸了";
            else if (com == 3)
                txt1.Text = "電腦出布,你贏了";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            com = random.Next(1, 4);
            if (com == 1)
                txt1.Text = "電腦出剪刀,你贏了";
            else if (com == 2)
                txt1.Text = "電腦出石頭,平手了";
            else if (com == 3)
                txt1.Text = "電腦出布,你輸了";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            com = random.Next(1, 4);
            if (com == 1)
                txt1.Text = "電腦出剪刀,你輸了";
            else if (com == 2)
                txt1.Text = "電腦出石頭,你贏了";
            else if (com == 3)
                txt1.Text = "電腦出布,平手了";
        }
    }
}