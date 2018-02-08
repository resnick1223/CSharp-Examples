using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example02_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = string.Format("Hello {0}", nameTextBox.Text);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
        }

        private void nameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            messageLabel.Text = string.Format("Hello {0}", nameTextBox.Text);
            nameTextBox.BackColor = SystemColors.Window;
        }

        private void nameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nameTextBox.BackColor = SystemColors.MenuHighlight;
        }
    }
}