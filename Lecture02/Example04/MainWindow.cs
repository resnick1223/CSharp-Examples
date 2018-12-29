using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example04
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double bmi = 0.0;
            double height = 0.0;
            double weight = 0.0;
            try
            {
                height = double.Parse(HeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("好好輸入身高可以嗎?");
                HeightTextBox.Text = string.Empty;
                HeightTextBox.Focus();
                return;
            }

            try
            {
                weight = double.Parse(WeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("好好輸入體重可以嗎?");
                WeightTextBox.Text = string.Empty;
                WeightTextBox.Focus();
                return;
            }
            height = height / 100.0;
            bmi = weight / (height * height);
            MessageBox.Show(string.Format("BMI: {0}", bmi.ToString("#.##")));
        }
    }
}