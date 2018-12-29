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

namespace Example02
{
    public partial class MainWindow : Form
    {
        public Student student;
        private StudentDataForm studentDataForm;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (studentNameTextBox.Text == "")
            {
                MessageBox.Show("請輸入學生姓名");
                return;
            }

            if (studentBirthdayTextBox.Text == "")
            {
                MessageBox.Show("請輸入學生生日");
                return;
            }

            student = new Student()
            {
                name = studentNameTextBox.Text,
                birthday = studentBirthdayTextBox.Text
            };

            studentDataForm = new StudentDataForm();
            studentDataForm.Render(student);
        }
    }
}