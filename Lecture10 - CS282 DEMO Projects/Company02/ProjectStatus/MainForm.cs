using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace ProjectStatus
{
    public partial class MainForm : Form
    {
        public ControlData dataFile = new ControlData();

        public MainForm()
        {
            InitializeComponent();
            dataFile.Initialize();
            InitializeView();
        }

        public void InitializeView()
        {
            totalItemLabel.Text = dataFile.TotalPages.ToString();
            currentItemLabel.Text = dataFile.CurrentPage.ToString();
            showDataInTextBox();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            dataFile.CurrentPage += 1;
            currentItemLabel.Text = dataFile.CurrentPage.ToString();
            showDataInTextBox();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            dataFile.CurrentPage -= 1;
            currentItemLabel.Text = dataFile.CurrentPage.ToString();
            showDataInTextBox();
        }

        private void showDataInTextBox()
        {
            yearValueTextBox.Text = dataFile.YearValue.ToString();
            projectNumberTextBox.Text = dataFile.ProjectNumber;
            productNameTextBox.Text = dataFile.ProductName;
            projectOpenDateTextBox.Text = dataFile.ProjectOpenDate;
            descriptionRichTextBox.Text = dataFile.ProductDescription;
            projectStatusRichTextBox.Text = dataFile.ProjectStatus;
            saftyStatusRichTextBox.Text = dataFile.SaftyStatus;
            projectNoteRichTextBox.Text = dataFile.ProjectNote;
        }

        private void projectOpenDateTextBox_Load(object sender, EventArgs e)
        {
            projectOpenDateTextBox.ShortcutsEnabled = false;  // 不啟用快速鍵
        }

        private void projectOpenDateTextBox_Leave(object sender, EventArgs e)
        {
            DateTime keyinDate;
            if (true == DateTime.TryParse(projectOpenDateTextBox.Text, out keyinDate))
            {
                // 是日期格式
                dataFile.ProjectOpenDate = projectOpenDateTextBox.Text;
            }
            else
            {
                // 不是日期格式

                projectOpenDateTextBox.Text = "yyyy/mm/dd";
                dataFile.ProjectOpenDate = "";
            }
        }

        private void YearValueTextBox_Load(object sender, EventArgs e)
        {
            yearValueTextBox.ShortcutsEnabled = false;  // 不啟用快速鍵
        }

        private void YearValueTextBox_KeyPress(object o, KeyPressEventArgs e)
        {
            // 使用 Char.IsDigit 方法 : 指示指定的 Unicode 字元是否分類為十進位數字。
            // e.KeyChar == (Char)48 ~ 57 -----> 0~9

            // Char.IsControl 方法 : 指示指定的 Unicode 字元是否分類為控制字元。
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter

            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void projectNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            dataFile.ProjectNumber = projectNumberTextBox.Text;
        }

        private void productNameTextBox_TextChanged(object sender, EventArgs e)
        {
            dataFile.ProductName = productNameTextBox.Text;
        }

        private void descriptionRichTextBox_TextChanged(object sender, EventArgs e)
        {
            dataFile.ProductDescription = descriptionRichTextBox.Text;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            dataFile.Save();
        }

        private void projectStatusRichTextBox_TextChanged(object sender, EventArgs e)
        {
            dataFile.ProjectStatus = projectStatusRichTextBox.Text;
        }

        private void saftyStatusRichTextBox_TextChanged(object sender, EventArgs e)
        {
            dataFile.SaftyStatus = saftyStatusRichTextBox.Text;
        }

        private void projectNoteRichTextBox_TextChanged(object sender, EventArgs e)
        {
            dataFile.ProjectNote = projectNoteRichTextBox.Text;
        }

        /*
        private void newButton_Click(object sender, EventArgs e)
        {
            dataFile.New();
            totalItemLabel.Text = dataFile.TotalPages.ToString();
            currentItemLabel.Text = dataFile.CurrentPage.ToString();
            showDataInTextBox();
        }
        */
    }
}