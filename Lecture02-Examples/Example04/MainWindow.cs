using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentLibrary;

namespace Example04
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            Score score = new Score();
            float gpa = score.ToGPA(scoreTextBox.Text);

            if (score.IsConvertable)
                gpaLabel.Text = "GPA: " + gpa.ToString();
            else
                MessageBox.Show("輸入格式錯誤，請重新輸入!");
        }
    }
}