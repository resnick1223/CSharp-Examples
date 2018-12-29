namespace Student
{
	partial class form_StudentCreate
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblLastName = new System.Windows.Forms.Label();
			this.txt_LastName = new System.Windows.Forms.TextBox();
			this.btn_insert = new System.Windows.Forms.Button();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblEnrollDate = new System.Windows.Forms.Label();
			this.txt_FirstName = new System.Windows.Forms.TextBox();
			this.dt_EnrollDate = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.lbl_password = new System.Windows.Forms.Label();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.txt_UserId = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblLastName.Location = new System.Drawing.Point(41, 31);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(84, 16);
			this.lblLastName.TabIndex = 0;
			this.lblLastName.Text = "LastName:";
			// 
			// txt_LastName
			// 
			this.txt_LastName.Location = new System.Drawing.Point(175, 31);
			this.txt_LastName.Name = "txt_LastName";
			this.txt_LastName.Size = new System.Drawing.Size(100, 22);
			this.txt_LastName.TabIndex = 1;
			// 
			// btn_insert
			// 
			this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_insert.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_insert.Location = new System.Drawing.Point(470, 26);
			this.btn_insert.Name = "btn_insert";
			this.btn_insert.Size = new System.Drawing.Size(75, 41);
			this.btn_insert.TabIndex = 2;
			this.btn_insert.Text = "Create";
			this.btn_insert.UseVisualStyleBackColor = true;
			this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblFirstName.Location = new System.Drawing.Point(41, 78);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(86, 16);
			this.lblFirstName.TabIndex = 3;
			this.lblFirstName.Text = "FirstName:";
			// 
			// lblEnrollDate
			// 
			this.lblEnrollDate.AutoSize = true;
			this.lblEnrollDate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblEnrollDate.Location = new System.Drawing.Point(41, 125);
			this.lblEnrollDate.Name = "lblEnrollDate";
			this.lblEnrollDate.Size = new System.Drawing.Size(130, 16);
			this.lblEnrollDate.TabIndex = 4;
			this.lblEnrollDate.Text = "Enrollment Date:";
			// 
			// txt_FirstName
			// 
			this.txt_FirstName.Location = new System.Drawing.Point(175, 78);
			this.txt_FirstName.Name = "txt_FirstName";
			this.txt_FirstName.Size = new System.Drawing.Size(100, 22);
			this.txt_FirstName.TabIndex = 2;
			// 
			// dt_EnrollDate
			// 
			this.dt_EnrollDate.Location = new System.Drawing.Point(175, 125);
			this.dt_EnrollDate.Name = "dt_EnrollDate";
			this.dt_EnrollDate.Size = new System.Drawing.Size(200, 22);
			this.dt_EnrollDate.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(41, 172);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "User ID:";
			// 
			// lbl_password
			// 
			this.lbl_password.AutoSize = true;
			this.lbl_password.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lbl_password.Location = new System.Drawing.Point(41, 219);
			this.lbl_password.Name = "lbl_password";
			this.lbl_password.Size = new System.Drawing.Size(80, 16);
			this.lbl_password.TabIndex = 6;
			this.lbl_password.Text = "Password:";
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(175, 219);
			this.txt_Password.MaxLength = 10;
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(100, 22);
			this.txt_Password.TabIndex = 5;
			// 
			// txt_UserId
			// 
			this.txt_UserId.Location = new System.Drawing.Point(175, 172);
			this.txt_UserId.MaxLength = 10;
			this.txt_UserId.Name = "txt_UserId";
			this.txt_UserId.Size = new System.Drawing.Size(100, 22);
			this.txt_UserId.TabIndex = 4;
			// 
			// form_StudentCreate
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 309);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txt_UserId);
			this.Controls.Add(this.lbl_password);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dt_EnrollDate);
			this.Controls.Add(this.txt_FirstName);
			this.Controls.Add(this.lblEnrollDate);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.btn_insert);
			this.Controls.Add(this.txt_LastName);
			this.Controls.Add(this.lblLastName);
			this.Name = "form_StudentCreate";
			this.Text = "Add Student";
			this.Load += new System.EventHandler(this.form_StudentCreate_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.TextBox txt_LastName;
		private System.Windows.Forms.Button btn_insert;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblEnrollDate;
		private System.Windows.Forms.TextBox txt_FirstName;
		private System.Windows.Forms.DateTimePicker dt_EnrollDate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbl_password;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.TextBox txt_UserId;
	}
}