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
	public partial class DeleteStudent : Form
	{
		SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=School;Integrated Security=true;" +
			"AttachDbFilename=c:\\Database\\School.mdf");
		SqlCommand cmd;
		SqlDataAdapter adapt;
		//ID variable used in Updating and Deleting Record  
		public int ID = 0;
		public DeleteStudent()
		{
			InitializeComponent();
			DisplayData();
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
		//dataGridView RowHeaderMouseClick Event  
		private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
			txt_FirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
			txt_LastName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
			dt_EnrollDate.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
			txt_UserId.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
			txt_Password.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
		}
		private void btn_delete_Click(object sender, EventArgs e)
		{

						if (ID != 0)
						{
							cmd = new SqlCommand("delete Student where id=@id", con);
							con.Open();
							cmd.Parameters.AddWithValue("@id", ID);
							cmd.ExecuteNonQuery();
							con.Close();
							MessageBox.Show("Record Deleted Successfully!");
							DisplayData();
							ClearData();
						}
						else
						{
							MessageBox.Show("Please Select Record to Delete");
						}
					
		}
		//Clear Data  
		private void ClearData()
		{
			txt_FirstName.Text = "";
			txt_LastName.Text = "";
			txt_UserId.Text =  "";
			txt_Password.Text = "";
			ID = 0;
		}
		private void DeleteStudent_Load(object sender, EventArgs e)
		{

		}
	}
}
