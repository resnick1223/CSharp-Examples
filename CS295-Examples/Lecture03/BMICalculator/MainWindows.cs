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
    public partial class MainWindows : Form
    {
        // 欄位
        private float height;

        private float weight;

        private float bmi;

        private string message = "BMI: {0}";

        public MainWindows()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            weight = 0.0f;
            height = 0.0f;
            bool success = false;

            success = float.TryParse(WeightTextBox.Text, out weight);
            if (!success)
            {
                MessageBox.Show("體重輸入錯誤");
                return;
            }

            success = float.TryParse(HeightTextBox.Text, out height);
            if (!success)
            {
                MessageBox.Show("身高輸入錯誤");
                return;
            }

            if (success)
            {
                height /= 100.0f;
                bmi = weight / (height * height);

                if (bmi > 25 || bmi < 20)
                    MessageLabel.BackColor = Color.Tomato;
                else
                    MessageLabel.BackColor = Color.GreenYellow;

                MessageLabel.Text = string.Format(message, bmi);
            }
        }
    }
}