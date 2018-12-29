using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
	public partial class LogIn : Form
	{
		

		public LogIn()
		{
			InitializeComponent();
		}

		private void btn_login_Click(object sender, EventArgs e)
		{
			LogIn_Verify loginVerify = new LogIn_Verify();
			loginVerify.Show();
			this.Hide();

		}
	}
}
