using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyMath;

namespace Example02
{
    public partial class Form1 : Form
    {
        private Vec2[] vectors;

        public Form1()
        {
            InitializeComponent();
            vectors = Vec2.Generate(-100, 100, 10);
            resultRichTextBox.Text = Vec2.ToString(vectors);
        }

        private void sortByXButton_Click(object sender, EventArgs e)
        {
            Vec2.selectedField = SelectedField.X;
            Array.Sort(vectors);
            resultRichTextBox.Text = Vec2.ToString(vectors);
        }

        private void sortByYButton_Click(object sender, EventArgs e)
        {
            Vec2.selectedField = SelectedField.Y;
            Array.Sort(vectors);
            resultRichTextBox.Text = Vec2.ToString(vectors);
        }

        private void sortByLengthButton_Click(object sender, EventArgs e)
        {
            Vec2.selectedField = SelectedField.Length;
            Array.Sort(vectors);
            resultRichTextBox.Text = Vec2.ToString(vectors);
        }
    }
}