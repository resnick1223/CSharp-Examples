namespace Student
{
	partial class CourseChooseList
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
			this.btn_detail = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(56, 99);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(362, 150);
			this.dataGridView1.TabIndex = 0;
			// 
			// btn_detail
			// 
			this.btn_detail.Location = new System.Drawing.Point(141, 12);
			this.btn_detail.Name = "btn_detail";
			this.btn_detail.Size = new System.Drawing.Size(234, 55);
			this.btn_detail.TabIndex = 1;
			this.btn_detail.Text = "明細";
			this.btn_detail.UseVisualStyleBackColor = true;
			this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
			// 
			// CourseChooseList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(459, 261);
			this.Controls.Add(this.btn_detail);
			this.Controls.Add(this.dataGridView1);
			this.Name = "CourseChooseList";
			this.Text = "CourseChooseList";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_detail;
	}
}