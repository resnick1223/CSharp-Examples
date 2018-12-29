namespace Student
{
	partial class CourseChooseListDetail
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
			this.lbl_studentID = new System.Windows.Forms.Label();
			this.txt_studentID = new System.Windows.Forms.TextBox();
			this.txt_FirstName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_LastName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(118, 111);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(334, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// lbl_studentID
			// 
			this.lbl_studentID.AutoSize = true;
			this.lbl_studentID.BackColor = System.Drawing.SystemColors.ControlLight;
			this.lbl_studentID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lbl_studentID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lbl_studentID.Location = new System.Drawing.Point(27, 26);
			this.lbl_studentID.Name = "lbl_studentID";
			this.lbl_studentID.Size = new System.Drawing.Size(55, 19);
			this.lbl_studentID.TabIndex = 1;
			this.lbl_studentID.Text = "學號:";
			// 
			// txt_studentID
			// 
			this.txt_studentID.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txt_studentID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_studentID.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.txt_studentID.Location = new System.Drawing.Point(118, 23);
			this.txt_studentID.Name = "txt_studentID";
			this.txt_studentID.Size = new System.Drawing.Size(100, 30);
			this.txt_studentID.TabIndex = 2;
			// 
			// txt_FirstName
			// 
			this.txt_FirstName.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txt_FirstName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_FirstName.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.txt_FirstName.Location = new System.Drawing.Point(118, 70);
			this.txt_FirstName.Name = "txt_FirstName";
			this.txt_FirstName.Size = new System.Drawing.Size(100, 30);
			this.txt_FirstName.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label1.Location = new System.Drawing.Point(27, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 19);
			this.label1.TabIndex = 3;
			this.label1.Text = "姓名:";
			// 
			// txt_LastName
			// 
			this.txt_LastName.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txt_LastName.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_LastName.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.txt_LastName.Location = new System.Drawing.Point(224, 70);
			this.txt_LastName.Name = "txt_LastName";
			this.txt_LastName.Size = new System.Drawing.Size(100, 30);
			this.txt_LastName.TabIndex = 5;
			// 
			// CourseChooseList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(589, 297);
			this.Controls.Add(this.txt_LastName);
			this.Controls.Add(this.txt_FirstName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_studentID);
			this.Controls.Add(this.lbl_studentID);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CourseChooseList";
			this.Text = "CourseChooseList";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label lbl_studentID;
		private System.Windows.Forms.TextBox txt_studentID;
		private System.Windows.Forms.TextBox txt_FirstName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_LastName;
	}
}