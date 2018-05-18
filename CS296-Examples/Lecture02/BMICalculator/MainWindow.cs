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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            int height = 0;
            float weight = 0.0f;
            float bmi = 0.0f;

            try
            {
                height = int.Parse(HeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("拜託請好好輸入身高!");
                HeightTextBox.Text = "";
                HeightTextBox.Focus();
                return;
            }

            try
            {
                weight = float.Parse(WeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("拜託請好好輸入體重!");
                WeightTextBox.Text = "";
                WeightTextBox.Focus();
                return;
            }
            bmi = weight / ((height / 100.0f) * (height / 100.0f));

            MessageBox.Show(string.Format("BMI: {0}", bmi.ToString("#.##")));
        }
    }
}