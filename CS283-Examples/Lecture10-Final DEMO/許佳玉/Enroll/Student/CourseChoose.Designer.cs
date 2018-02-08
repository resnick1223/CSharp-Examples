namespace Student
{
	partial class CourseChoose
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
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.lbl_id = new System.Windows.Forms.Label();
			this.txt_studentID = new System.Windows.Forms.TextBox();
			this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(62, 79);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(774, 206);
			this.dataGridView1.TabIndex = 0;
			// 
			// btn_add
			// 
			this.btn_add.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_add.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_add.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btn_add.Location = new System.Drawing.Point(475, 26);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(143, 38);
			this.btn_add.TabIndex = 1;
			this.btn_add.Text = "加選";
			this.btn_add.UseVisualStyleBackColor = false;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_delete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_delete.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btn_delete.Location = new System.Drawing.Point(640, 26);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(143, 38);
			this.btn_delete.TabIndex = 2;
			this.btn_delete.Text = "退選";
			this.btn_delete.UseVisualStyleBackColor = false;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// lbl_id
			// 
			this.lbl_id.AutoSize = true;
			this.lbl_id.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lbl_id.Location = new System.Drawing.Point(58, 29);
			this.lbl_id.Name = "lbl_id";
			this.lbl_id.Size = new System.Drawing.Size(55, 19);
			this.lbl_id.TabIndex = 3;
			this.lbl_id.Text = "學號:";
			// 
			// txt_studentID
			// 
			this.txt_studentID.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.txt_studentID.Location = new System.Drawing.Point(152, 26);
			this.txt_studentID.Name = "txt_studentID";
			this.txt_studentID.Size = new System.Drawing.Size(143, 30);
			this.txt_studentID.TabIndex = 4;
			// 
			// vScrollBar1
			// 
			this.vScrollBar1.Location = new System.Drawing.Point(843, 79);
			this.vScrollBar1.Name = "vScrollBar1";
			this.vScrollBar1.Size = new System.Drawing.Size(17, 206);
			this.vScrollBar1.TabIndex = 5;
			// 
			// CourseChoose
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(869, 318);
			this.Controls.Add(this.vScrollBar1);
			this.Controls.Add(this.txt_studentID);
			this.Controls.Add(this.lbl_id);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CourseChoose";
			this.Text = "CourseChoose";
			this.Load += new System.EventHandler(this.CourseChoose_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Label lbl_id;
		private System.Windows.Forms.TextBox txt_studentID;
		private System.Windows.Forms.VScrollBar vScrollBar1;
	}
}