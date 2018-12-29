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
	public partial class StudentList : Form
	{
		public  SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=School;Integrated Security=true;" +
		"AttachDbFilename=c:\\Database\\School.mdf");
		public SqlCommand cmd;
		public SqlDataAdapter adapt;

		public StudentList()
		{
			InitializeComponent();
			DisplayData();
		}

		private void StudentList_Load(object sender, EventArgs e)
		{
		  	
		}
		//Display Data in DataGridView  
		private void DisplayData()
		{
			con.Open();
			DataTable dt = new DataTable();
			adapt = new SqlDataAdapter("select * from Student", con);
			adapt.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
	}
}
