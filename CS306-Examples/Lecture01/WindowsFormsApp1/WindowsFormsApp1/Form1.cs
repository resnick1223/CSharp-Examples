using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("我今天心情{0}{1}", "很", "好");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = string.Format("我今天心情{0}{1}", textBox1.Text, textBox2.Text);
        }
    }
}