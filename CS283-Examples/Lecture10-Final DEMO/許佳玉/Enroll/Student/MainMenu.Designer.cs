namespace Student
{
	partial class MainMenu
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.menuSchool = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.studentMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_StudentList = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_CreateStudent = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_studentEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_studentDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_studentMaintain = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_course = new System.Windows.Forms.ToolStripMenuItem();
			this.menu_courseChoose = new System.Windows.Forms.ToolStripMenuItem();
			this.insturctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.departmentsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSchool.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuSchool
			// 
			this.menuSchool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem1,
            this.studentMenu,
            this.menu_course,
            this.insturctorsToolStripMenuItem,
            this.departmentsToolStripMenuItem1});
			this.menuSchool.Location = new System.Drawing.Point(0, 0);
			this.menuSchool.Name = "menuSchool";
			this.menuSchool.Size = new System.Drawing.Size(579, 24);
			this.menuSchool.TabIndex = 0;
			this.menuSchool.Text = "menuSchool";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
			this.toolStripMenuItem1.Text = "Home";
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
			this.aboutToolStripMenuItem1.Text = "About";
			// 
			// studentMenu
			// 
			this.studentMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_StudentList,
            this.menu_CreateStudent,
            this.menu_studentEdit,
            this.menu_studentDelete,
            this.menu_studentMaintain});
			this.studentMenu.Name = "studentMenu";
			this.studentMenu.Size = new System.Drawing.Size(68, 20);
			this.studentMenu.Text = "Students";
			// 
			// menu_StudentList
			// 
			this.menu_StudentList.CheckOnClick = true;
			this.menu_StudentList.Name = "menu_StudentList";
			this.menu_StudentList.Size = new System.Drawing.Size(152, 22);
			this.menu_StudentList.Text = "List";
			this.menu_StudentList.Click += new System.EventHandler(this.menu_StudentList_Click);
			// 
			// menu_CreateStudent
			// 
			this.menu_CreateStudent.Name = "menu_CreateStudent";
			this.menu_CreateStudent.Size = new System.Drawing.Size(152, 22);
			this.menu_CreateStudent.Text = "Create";
			this.menu_CreateStudent.Click += new System.EventHandler(this.menu_CreateStudent_Click);
			// 
			// menu_studentEdit
			// 
			this.menu_studentEdit.Name = "menu_studentEdit";
			this.menu_studentEdit.Size = new System.Drawing.Size(152, 22);
			this.menu_studentEdit.Text = "Edit";
			this.menu_studentEdit.Click += new System.EventHandler(this.menu_studentEdit_Click);
			// 
			// menu_studentDelete
			// 
			this.menu_studentDelete.Name = "menu_studentDelete";
			this.menu_studentDelete.Size = new System.Drawing.Size(152, 22);
			this.menu_studentDelete.Text = "Delete";
			this.menu_studentDelete.Click += new System.EventHandler(this.menu_studentDelete_Click);
			// 
			// menu_studentMaintain
			// 
			this.menu_studentMaintain.Name = "menu_studentMaintain";
			this.menu_studentMaintain.Size = new System.Drawing.Size(152, 22);
			this.menu_studentMaintain.Text = "Maintain";
			this.menu_studentMaintain.Click += new System.EventHandler(this.menu_studentMaintain_Click);
			// 
			// menu_course
			// 
			this.menu_course.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_courseChoose});
			this.menu_course.Name = "menu_course";
			this.menu_course.Size = new System.Drawing.Size(63, 20);
			this.menu_course.Text = "Courses";
			// 
			// menu_courseChoose
			// 
			this.menu_courseChoose.Name = "menu_courseChoose";
			this.menu_courseChoose.Size = new System.Drawing.Size(110, 22);
			this.menu_courseChoose.Text = "加退選";
			this.menu_courseChoose.Click += new System.EventHandler(this.menu_courseChoose_Click);
			// 
			// insturctorsToolStripMenuItem
			// 
			this.insturctorsToolStripMenuItem.Name = "insturctorsToolStripMenuItem";
			this.insturctorsToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.insturctorsToolStripMenuItem.Text = "Insturctors";
			// 
			// departmentsToolStripMenuItem1
			// 
			this.departmentsToolStripMenuItem1.Name = "departmentsToolStripMenuItem1";
			this.departmentsToolStripMenuItem1.Size = new System.Drawing.Size(92, 20);
			this.departmentsToolStripMenuItem1.Text = "Departments";
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 261);
			this.Controls.Add(this.menuSchool);
			this.MainMenuStrip = this.menuSchool;
			this.Name = "MainMenu";
			this.Text = "AAA University";
			this.Load += new System.EventHandler(this.Main_Load);
			this.menuSchool.ResumeLayout(false);
			this.menuSchool.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuSchool;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem studentMenu;
		private System.Windows.Forms.ToolStripMenuItem menu_StudentList;
		private System.Windows.Forms.ToolStripMenuItem menu_CreateStudent;
		private System.Windows.Forms.ToolStripMenuItem menu_studentEdit;
		private System.Windows.Forms.ToolStripMenuItem menu_course;
		private System.Windows.Forms.ToolStripMenuItem insturctorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem menu_studentDelete;
		private System.Windows.Forms.ToolStripMenuItem menu_studentMaintain;
		private System.Windows.Forms.ToolStripMenuItem menu_courseChoose;
	}
}

