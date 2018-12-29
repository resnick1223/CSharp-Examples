namespace Student
{
	partial class LogIn
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
			this.btn_login = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_login
			// 
			this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_login.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_login.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.btn_login.Location = new System.Drawing.Point(118, 60);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(151, 68);
			this.btn_login.TabIndex = 0;
			this.btn_login.Text = "登入";
			this.btn_login.UseVisualStyleBackColor = true;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(382, 261);
			this.Controls.Add(this.btn_login);
			this.Name = "LogIn";
			this.Text = "LogIn";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_login;
	}
}