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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void execButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = number1TextBox.Text + number2TextBox.Text;
        }

        private void execAddButton_Click(object sender, EventArgs e)
        {
            int number1 = 0;
            bool success = int.TryParse(number1TextBox.Text, out number1);
            if (!success)
            {
                MessageBox.Show("number 1 輸入錯誤，請重新輸入");
                return;
            }
            int number2 = 0;
            success = int.TryParse(number2TextBox.Text, out number2);
            if (!success)
            {
                MessageBox.Show("number 2 輸入錯誤，請重新輸入");
                return;
            }
            resultTextBox.Text = (number1 + number2).ToString();
        }
    }
}