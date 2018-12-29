namespace Student
{
	partial class DeleteStudent
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
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_delete = new System.Windows.Forms.Button();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.txt_UserId = new System.Windows.Forms.TextBox();
			this.lbl_password = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dt_EnrollDate = new System.Windows.Forms.DateTimePicker();
			this.txt_FirstName = new System.Windows.Forms.TextBox();
			this.lblEnrollDate = new System.Windows.Forms.Label();
			this.lblFirstName = new System.Windows.Forms.Label();
			this.txt_LastName = new System.Windows.Forms.TextBox();
			this.lblLastName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(454, 81);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(378, 171);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_delete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_delete.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btn_delete.Location = new System.Drawing.Point(454, 21);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(206, 33);
			this.btn_delete.TabIndex = 1;
			this.btn_delete.Text = "刪除";
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(166, 209);
			this.txt_Password.MaxLength = 10;
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(100, 22);
			this.txt_Password.TabIndex = 14;
			// 
			// txt_UserId
			// 
			this.txt_UserId.Location = new System.Drawing.Point(166, 162);
			this.txt_UserId.MaxLength = 10;
			this.txt_UserId.Name = "txt_UserId";
			this.txt_UserId.Size = new System.Drawing.Size(100, 22);
			this.txt_UserId.TabIndex = 12;
			// 
			// lbl_password
			// 
			this.lbl_password.AutoSize = true;
			this.lbl_password.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lbl_password.Location = new System.Drawing.Point(32, 209);
			this.lbl_password.Name = "lbl_password";
			this.lbl_password.Size = new System.Drawing.Size(80, 16);
			this.lbl_password.TabIndex = 16;
			this.lbl_password.Text = "Password:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(32, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 16);
			this.label1.TabIndex = 15;
			this.label1.Text = "User ID:";
			// 
			// dt_EnrollDate
			// 
			this.dt_EnrollDate.Location = new System.Drawing.Point(166, 115);
			this.dt_EnrollDate.Name = "dt_EnrollDate";
			this.dt_EnrollDate.Size = new System.Drawing.Size(200, 22);
			this.dt_EnrollDate.TabIndex = 10;
			// 
			// txt_FirstName
			// 
			this.txt_FirstName.Location = new System.Drawing.Point(166, 68);
			this.txt_FirstName.Name = "txt_FirstName";
			this.txt_FirstName.Size = new System.Drawing.Size(100, 22);
			this.txt_FirstName.TabIndex = 9;
			// 
			// lblEnrollDate
			// 
			this.lblEnrollDate.AutoSize = true;
			this.lblEnrollDate.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblEnrollDate.Location = new System.Drawing.Point(32, 115);
			this.lblEnrollDate.Name = "lblEnrollDate";
			this.lblEnrollDate.Size = new System.Drawing.Size(130, 16);
			this.lblEnrollDate.TabIndex = 13;
			this.lblEnrollDate.Text = "Enrollment Date:";
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblFirstName.Location = new System.Drawing.Point(32, 68);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(86, 16);
			this.lblFirstName.TabIndex = 11;
			this.lblFirstName.Text = "FirstName:";
			// 
			// txt_LastName
			// 
			this.txt_LastName.Location = new System.Drawing.Point(166, 21);
			this.txt_LastName.Name = "txt_LastName";
			this.txt_LastName.Size = new System.Drawing.Size(100, 22);
			this.txt_LastName.TabIndex = 8;
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lblLastName.Location = new System.Drawing.Point(32, 21);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(84, 16);
			this.lblLastName.TabIndex = 7;
			this.lblLastName.Text = "LastName:";
			// 
			// DeleteStudent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 303);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.txt_UserId);
			this.Controls.Add(this.lbl_password);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dt_EnrollDate);
			this.Controls.Add(this.txt_FirstName);
			this.Controls.Add(this.lblEnrollDate);
			this.Controls.Add(this.lblFirstName);
			this.Controls.Add(this.txt_LastName);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.dataGridView1);
			this.Name = "DeleteStudent";
			this.Text = "DeleteStudent";
			this.Load += new System.EventHandler(this.DeleteStudent_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.TextBox txt_UserId;
		private System.Windows.Forms.Label lbl_password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dt_EnrollDate;
		private System.Windows.Forms.TextBox txt_FirstName;
		private System.Windows.Forms.Label lblEnrollDate;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.TextBox txt_LastName;
		private System.Windows.Forms.Label lblLastName;
	}
}