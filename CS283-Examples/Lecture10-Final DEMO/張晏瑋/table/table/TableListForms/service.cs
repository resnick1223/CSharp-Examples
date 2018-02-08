using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using maintaindatabaseForms;
using RetiredCarListForms;

namespace TableListForms
{
    public partial class TableListForm : Form
    {
        public TableListForm()
        {
            InitializeComponent();
        }

        private void maintainbutton_Click(object sender, EventArgs e)
        {
            maintaindatabaseForm maintaintain = new maintaindatabaseForm();
            maintaintain.Visible = true;
        }

        private void retiredbutton_Click(object sender, EventArgs e)
        {
            RetiredCarListForm retired = new RetiredCarListForm();
            retired.Visible = true;
        }
    }
}