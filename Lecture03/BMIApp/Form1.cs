using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIApp
{
    public partial class Form1 : Form
    {
        private double height;
        private double weight;
        private double bmi;
        private string result;

        public Form1()
        {
            InitializeComponent();
        }

        private void bmiButton_Click(object sender, EventArgs e)
        {
            // 取得欄位資料，計算bmi
            CalculateBMI();
            // 繪製畫面
            Render();
        }

        private void CalculateBMI()
        {
            bool success = double.TryParse(weightTextBox.Text, out weight);
            if (!success)
            {
                MessageBox.Show("體重輸入錯誤，請重新輸入");
                return;
            }

            success = double.TryParse(heightTextBox.Text, out height);

            if (!success)
            {
                MessageBox.Show("身高輸入錯誤，請重新輸入");
                return;
            }
            else
            {
                height /= 100.0;
            }

            bmi = weight / (height * height);

            result = string.Format("BMI: {0}, {1}"
               , bmi.ToString("#.##")
               , IsHealthy() ? "健康" : "需要注意");
        }

        private bool IsHealthy()
        {
            return bmi <= 24.9 && bmi >= 18.9;
        }

        private void Render()
        {
            resultLabel.Text = result;
        }
    }
}