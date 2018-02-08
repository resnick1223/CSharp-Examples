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
	public partial class CourseChooseList : Form
	{
		public CourseChooseList()
		{
			InitializeComponent();
		}

		private void btn_detail_Click(object sender, EventArgs e)
		{
			CourseChooseListDetail detail = new CourseChooseListDetail();
			detail.Show();
		}
	}
}
