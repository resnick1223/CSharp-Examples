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
	public partial class LogIn_Verify : Form
	{
		public const int MaxTry = 3;
		public int FailTry;
		public LogIn_Verify logV;
		public SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=School;Integrated Security=true;" +
			"AttachDbFilename=c:\\Database\\School.mdf");

		
		public LogIn_Verify()
		{
			InitializeComponent();
			logV = this;
			FailTry = 0;
		}

		private void btn_send_Click(object sender, EventArgs e)
		{
			if (FailTry >= MaxTry)
			{
				MessageBox.Show("Login fails too many times, system is being locked!");

				logV.Hide();
			}
			else
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("select user_id, password from login where user_id ='" + txt_UserId.Text + "' and password='" +
					txt_Password.Text + "'", con);

				SqlDataAdapter adapt = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();

				adapt.Fill(dt);

				if (dt.Rows.Count > 0)
				{
					MessageBox.Show("Login sucess! Welcome!");
					MainMenu main = new MainMenu();
					main.Show();
					this.Hide();
				}
				else
				{
					FailTry += 1;
					MessageBox.Show("Invalid Login: {0} ! Please check user name and password!", FailTry.ToString());
				}

				con.Close();

			}
		}

		
	}
}
