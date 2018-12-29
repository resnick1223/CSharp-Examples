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
        float weight = 0.0f;
        float height = 0.0f;
        float bmi = 0.0f;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                weight = float.Parse(weightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("體重輸入錯了啦，不會輸入數字阿");
                weightTextBox.Text = "";
                weightTextBox.Focus();
                return;
            }

            try
            {
                height = float.Parse(heightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("身高輸入錯了啦，不會輸入數字阿");
                heightTextBox.Text = "";
                heightTextBox.Focus();
                return;
            }

            try
            {
                height = height / 100.0f;
                bmi = weight / (height * height);
                bmiLabel.Text = string.Format("BMI: {0}", bmi);
                if(bmi >= 18.5 && bmi <= 24.9)
                {
                    MessageBox.Show("不錯喔，BMI在安全範圍");
                }
                else
                {
                    MessageBox.Show("糟糕了，該好好養身了");
                }
            }
            catch
            {
                MessageBox.Show("看來是分母有問題喔，給我回去檢查");
                return;
            }

        }
    }
}
