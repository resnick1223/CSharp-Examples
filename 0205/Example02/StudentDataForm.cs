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
    public partial class StudentDataForm : Form
    {
        public StudentDataForm()
        {
            InitializeComponent();
        }

        public void Render(Student student)
        {
            this.studentNameLabel.Text = student.name;
            this.studentBirthdayLabel.Text = student.birthday;
            this.titleLabel.Text = string.Format(this.titleLabel.Text, student.name);
            this.ShowDialog();
        }
    }
}