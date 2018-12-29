using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;

namespace StudentsAdmin
{
    public partial class CreateUserForm : Form
    {
        private string project = "acs303-example";

        public event EventHandler StudentAdded;

        public CreateUserForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            FirestoreDb db = FirestoreDb.Create(project);

            Dictionary<string, object> student = new Dictionary<string, object>
            {
                { "name", studentNameTextBox.Text },
                { "phone", studentPhoneTextBox.Text }
            };
            DocumentReference studentRef = await db.Collection("students").AddAsync(student);
            MessageBox.Show(string.Format("Added document with ID: {0}.", studentRef.Id));
            StudentAdded(this, new StudentData() { Id = studentRef.Id, Name = studentNameTextBox.Text, Phone = studentPhoneTextBox.Text });
        }

        private void studentPhoneLabel_Click(object sender, EventArgs e)
        {
        }

        private void studentNameTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void studentPhoneTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void studentLabel_Click(object sender, EventArgs e)
        {
        }
    }
}