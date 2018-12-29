using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double height = 0.0;
            double weight = 0.0;
            double bmi = 0.0;
            try
            {
                height = double.Parse(heightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("身高輸入錯誤，請重新輸入");
                heightTextBox.Text = "";
                heightTextBox.Focus();
                return;
            }

            try
            {
                weight = double.Parse(weightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("體重輸入錯誤，請重新輸入");
                return;
            }
            height = height / 100;

            try
            {
                bmi = weight / height / height;
            }
            catch
            {
                MessageBox.Show("身高不能為0，請重新輸入");
                return;
            }

            resultRichTextBox.Text = string.Format("BMI = {0}", bmi);
        }
    }
}