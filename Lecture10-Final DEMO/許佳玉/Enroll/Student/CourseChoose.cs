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
	public partial class CourseChoose : Form
	{

		SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=School;Integrated Security=true;" +
			"AttachDbFilename=c:\\Database\\School.mdf");
		SqlCommand cmd;
		SqlDataAdapter adapt;
		//ID variable used in Updating and Deleting Record  
		int EnrollID = 1;
		int CourseID = 1;

		public CourseChoose()
		{
			InitializeComponent();
			DisplayData();
		}
		//Display Data in DataGridView  
		private void DisplayData()
		{
			con.Open();
			DataTable dt = new DataTable();
			adapt = new SqlDataAdapter("select * from course", con);
			adapt.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
		//Insert Data  
		private void btn_add_Click(object sender, EventArgs e)
		{
			
			if (txt_studentID.Text != "" )
			{
				cmd = new SqlCommand("insert into enroll(course_id,student_id) values(@course_id,@student_id)", con);
				con.Open();
				cmd.Parameters.AddWithValue("@student_id", txt_studentID.Text);
				cmd.Parameters.AddWithValue("@course_id", CourseID);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Record Inserted Successfully");
				DisplayData();
				//ClearData();
			}
			else
			{
				MessageBox.Show("Please Provide Details!");
			}
			
		}
		
		//dataGridView1 RowHeaderMouseClick Event  
		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			EnrollID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			CourseID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
			//txt_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			//txt_state.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
		}
		private void CourseChoose_Load(object sender, EventArgs e)
		{

		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			if (EnrollID != 0)
			{
				cmd = new SqlCommand("delete enroll where enroll_id=@id", con);
				con.Open();
				cmd.Parameters.AddWithValue("@id", EnrollID);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Record Deleted Successfully!");
				//DisplayData();
				//ClearData();
			}
			else
			{
				MessageBox.Show("Please Select Record to Delete");
			}

		}
	}
}
