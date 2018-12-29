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
    public partial class UpdateUserForm : Form
    {
        private string project = "acs303-example";

        public UpdateUserForm()
        {
            InitializeComponent();
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            FirestoreDb db = FirestoreDb.Create(project);

            Dictionary<FieldPath, object> student = new Dictionary<FieldPath, object>
            {
                { new FieldPath("name"), studentNameTextBox.Text },
                { new FieldPath("phone"), studentPhoneTextBox.Text }
            };
            DocumentReference studentRef = db.Document("students/" + studentIdTextBox.Text);
            WriteResult result = await studentRef.UpdateAsync(student);
        }
    }
}