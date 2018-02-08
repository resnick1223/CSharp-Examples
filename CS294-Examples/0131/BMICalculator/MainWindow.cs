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
        // TODO 宣告需要的變數
        private double height;

        private double weight;
        private double bmi;
        private string bmiTemplate = "BMI數值: {0}";
        private string infoTempate = "狀態: {0}";
        private bool success = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // TODO 檢查使用者輸入
            VerifyUserInputs();

            if (success)
            {
                // TODO 計算BMI
                CalculateBMI();

                // TODO 繪製畫面
                Render();
            }
        }

        private void VerifyUserInputs()
        {
            success = double.TryParse(heightTextBox.Text, out height);
            if (!success)
            {
                MessageBox.Show("身高輸入錯誤，請重新輸入");
                heightTextBox.Text = "";
                heightTextBox.Focus();
                return;
            }
            else
            {
                if (height <= 0.0)
                {
                    MessageBox.Show("身高不能小於或等於0，請重新輸入");
                    heightTextBox.Text = "";
                    heightTextBox.Focus();
                    success = false;
                    return;
                }
            }

            success = double.TryParse(weightTextBox.Text, out weight);
            if (!success)
            {
                MessageBox.Show("體重輸入錯誤，請重新輸入");
                weightTextBox.Text = "";
                weightTextBox.Focus();
                return;
            }
            else
            {
                if (weight <= 0.0)
                {
                    MessageBox.Show("體重不能小於或等於0，請重新輸入");
                    weightTextBox.Text = "";
                    weightTextBox.Focus();
                    success = false;
                    return;
                }
            }
        }

        private void CalculateBMI()
        {
            bmi = weight / ((height / 100.0) * (height / 100.0));
        }

        private bool IsHealthy()
        {
            return bmi > 18.5 && bmi < 24.5;
        }

        private void Render()
        {
            bmiLabel.Text = string.Format(bmiTemplate, bmi.ToString("#.##"));
            infoLabel.Text = string.Format(infoTempate, IsHealthy() ? "正常" : "異常");
            infoLabel.BackColor = IsHealthy() ? Color.GreenYellow : Color.IndianRed;
        }
    }
}