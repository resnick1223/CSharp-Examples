namespace Student
{
	partial class LogIn_Verify
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
			this.lbl_id = new System.Windows.Forms.Label();
			this.txt_UserId = new System.Windows.Forms.TextBox();
			this.txt_Password = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_send = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbl_id
			// 
			this.lbl_id.AutoSize = true;
			this.lbl_id.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.lbl_id.Location = new System.Drawing.Point(40, 45);
			this.lbl_id.Name = "lbl_id";
			this.lbl_id.Size = new System.Drawing.Size(115, 19);
			this.lbl_id.TabIndex = 0;
			this.lbl_id.Text = "使用者名稱:";
			// 
			// txt_UserId
			// 
			this.txt_UserId.Location = new System.Drawing.Point(157, 42);
			this.txt_UserId.Name = "txt_UserId";
			this.txt_UserId.Size = new System.Drawing.Size(129, 22);
			this.txt_UserId.TabIndex = 1;
			
			// 
			// txt_Password
			// 
			this.txt_Password.Location = new System.Drawing.Point(157, 95);
			this.txt_Password.Name = "txt_Password";
			this.txt_Password.Size = new System.Drawing.Size(129, 22);
			this.txt_Password.TabIndex = 3;
			
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(40, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "密碼:";
			// 
			// btn_send
			// 
			this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_send.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_send.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btn_send.Location = new System.Drawing.Point(157, 169);
			this.btn_send.Name = "btn_send";
			this.btn_send.Size = new System.Drawing.Size(106, 45);
			this.btn_send.TabIndex = 4;
			this.btn_send.Text = "送出";
			this.btn_send.UseVisualStyleBackColor = true;
			this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
			// 
			// LogIn_Verify
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 261);
			this.Controls.Add(this.btn_send);
			this.Controls.Add(this.txt_Password);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_UserId);
			this.Controls.Add(this.lbl_id);
			this.Name = "LogIn_Verify";
			this.Text = "LogIn_Verify";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbl_id;
		private System.Windows.Forms.TextBox txt_UserId;
		private System.Windows.Forms.TextBox txt_Password;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_send;
	}
}