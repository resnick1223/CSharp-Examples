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
    public partial class MainWindow : Form
    {
        private string project = "acs303-example";
        private CreateUserForm createUserForm;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void 新增學生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createUserForm = new CreateUserForm();
            createUserForm.Show();
            createUserForm.StudentAdded += this.AddStudent;
        }

        private void 更新學生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new UpdateUserForm()).Show();
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            FirestoreDb db = FirestoreDb.Create(project);
            CollectionReference studentsRef = db.Collection("students");
            QuerySnapshot studentsSnapshot = await studentsRef.GetSnapshotAsync();
            foreach (DocumentSnapshot studentSnapshot in studentsSnapshot.Documents)
            {
                if (studentSnapshot.Exists)
                {
                    Console.WriteLine("Document data for {0} document:", studentSnapshot.Id);
                    Dictionary<string, object> student = studentSnapshot.ToDictionary();
                    studentsDataGrid.Rows.Add(new string[] { studentSnapshot.Id, student["name"].ToString(), student["phone"].ToString() });
                }
            }
        }

        public void AddStudent(object sender, EventArgs e)
        {
            StudentData student = e as StudentData;
            studentsDataGrid.Rows.Add(student.ToStringArray());
        }
    }
}