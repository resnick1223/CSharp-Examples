using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShellLibrary;

namespace Example03
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void executeButton_Click(object sender, EventArgs e)
        {
            string ratesString = Shell.Execute("python", @"C:\Users\Resnick\pyquery\crawler.py");

            string[] rates = ratesString.Split(' ');

            Render(rates, 4);
        }

        public void Render(string[] data, int cols)
        {
            int rows =
                data.Length % cols == 0 ?
                data.Length / cols : data.Length / cols + 1;

            for (int row = 0; row < rows; row++)
            {
                int count = row == rows - 1 ? data.Length % cols : cols;
                string[] rowData = new string[count];
                for (int col = 0; col < count; col++)
                {
                    int index = row * cols + col;
                    rowData[col] = data[index];
                }
                resultDataGridView.Rows.Add(rowData);
            }
        }
    }
}
