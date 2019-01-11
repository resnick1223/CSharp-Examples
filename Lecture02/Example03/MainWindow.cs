using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLibrary;

namespace Example03
{
    public partial class MainWindow : Form
    {
        #region 建構式

        public MainWindow()
        {
            InitializeComponent();
        }

        #endregion 建構式

        // 事件處理器
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            try
            {
                student.Height = float.Parse(HeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("對，我就在說你，是不會好好輸入嗎");
            }

            try
            {
                student.Weight = float.Parse(WeightTextBox.Text);
            }
            catch
            {
                MessageBox.Show("對，我就在說你，是不會好好輸入嗎");
            }

            // 格式化 字串
            ResultLabel.Text = string.Format("BMI: {0}", student.BMI.ToString("#.##"));
        }
    }
}