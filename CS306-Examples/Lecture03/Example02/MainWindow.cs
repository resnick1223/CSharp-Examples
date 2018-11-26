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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CreateStudentButton_Click(object sender, EventArgs e)
        {
            student = new Student()
            {
                name = "王亭蓓",
                contact = new Contact()
                {
                    address = "...",
                    email = "...",
                    phone = "0912345678"
                }
            };
            MessageBox.Show(
                string.Format("學生姓名:{0}, 電話:{1}"
                , student.name, student.contact.phone)
            );
        }
    }
}