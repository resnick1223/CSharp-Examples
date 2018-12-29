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
	public partial class form_StudentCreate : Form
	{
		public static SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=School;Integrated Security=true;" +
		"AttachDbFilename=c:\\Database\\School.mdf");
		public static SqlCommand cmd;
		public static SqlDataAdapter adapt;

		public form_StudentCreate()
		{
			InitializeComponent();
		}

		//Insert Data  
		private void btn_insert_Click(object sender, EventArgs e)
		{
			

				if (txt_LastName.Text != "" && txt_FirstName.Text != "")
				{
				
				
					cmd = new SqlCommand(@"insert into Student(
                     first_name,last_name, enroll_date, user_id, password) values(
                    @first_name,@last_name,@enroll_date,@user_id,@password)", con);
					con.Open();
					cmd.Parameters.AddWithValue("@first_name", txt_FirstName.Text);
					cmd.Parameters.AddWithValue("@last_name", txt_LastName.Text);
				    cmd.Parameters.AddWithValue("@enroll_date", DateTime.Parse(dt_EnrollDate.Text));
					cmd.Parameters.AddWithValue("@user_id", txt_UserId.Text);
					cmd.Parameters.AddWithValue("@password", txt_Password.Text);
					cmd.ExecuteNonQuery();
					con.Close();
					MessageBox.Show("Record Inserted Successfully");
					//DisplayData();
					ClearData();
				}
				else
				{
					MessageBox.Show("Please Provide Details!");
				}
			
		}

		private void form_StudentCreate_Load(object sender, EventArgs e)
		{

		}
		//Clear Data  
		private void ClearData()
		{
			txt_FirstName.Text = "";
			txt_LastName.Text = "";
			txt_UserId.Text = "";
			txt_Password.Text = "";
			dt_EnrollDate.Text = "";
		}

	}
}
