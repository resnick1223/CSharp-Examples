using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Student
{
	public partial class MainMenu : Form
	{
		
		public MainMenu()
		{
			InitializeComponent();
		}

	

		private void Main_Load(object sender, EventArgs e)
		{
			
		}

		private void menu_StudentList_Click(object sender, EventArgs e)
		{
			StudentList studentList = new StudentList();
		    studentList.Show();
		}
		private void menu_CreateStudent_Click(object sender, EventArgs e)
		{
			form_StudentCreate form_create = new form_StudentCreate();
			form_create.Show();
		}

		private void menu_studentMaintain_Click(object sender, EventArgs e)
		{

		}

		private void menu_studentDelete_Click(object sender, EventArgs e)
		{
			DeleteStudent deleteStudent = new DeleteStudent();
			deleteStudent.Show();
		}
		private void menu_studentEdit_Click(object sender, EventArgs e)
		{

		}

		private void menu_courseChoose_Click(object sender, EventArgs e)
		{
			CourseChoose courseChoose = new CourseChoose();
			courseChoose.Show();
		}

		
	}
}
