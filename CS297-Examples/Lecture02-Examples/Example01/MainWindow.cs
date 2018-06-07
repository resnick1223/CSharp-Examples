using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            float height = 0.0f; //區域變數
            float weight = 0.0f;
            float bmi = 0.0f;

            try
            {
                height = float.Parse(heightTextBox.Text) / 100.0f;
            }
            catch
            {
                MessageBox.Show("身高輸入不對喔");
                heightTextBox.Text = string.Empty;
                heightTextBox.Focus();
                return;
            }
            try
            {
                weight = float.Parse(weightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("體重輸入不對喔");
                weightTextBox.Text = string.Empty;
                weightTextBox.Focus();
                return;
            }
            try
            {
                bmi = weight / (height * height);
            }
            catch
            {
                MessageBox.Show("身高不能是0喔");
                return;
            }
            resultLabel.Text = string.Format("BMI: {0}", bmi.ToString("#.##"));

            if(bmi >= 25)
            {
                MessageBox.Show("這樣不行喔，要注意!");
            }else if(bmi <= 20)
            {
                MessageBox.Show("太瘦囉QQ，多吃點!");

            }
            else
            {
                MessageBox.Show("不錯喔，繼續保持!");
            }
        }
    }
}
