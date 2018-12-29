namespace StudentsAdmin
{
    partial class UpdateUserForm
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
            this.updateButton = new System.Windows.Forms.Button();
            this.studentPhoneTextBox = new System.Windows.Forms.TextBox();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentPhoneLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(34, 216);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(144, 43);
            this.updateButton.TabIndex = 9;
            this.updateButton.Text = "更新資料";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // studentPhoneTextBox
            // 
            this.studentPhoneTextBox.Location = new System.Drawing.Point(152, 90);
            this.studentPhoneTextBox.Name = "studentPhoneTextBox";
            this.studentPhoneTextBox.Size = new System.Drawing.Size(216, 38);
            this.studentPhoneTextBox.TabIndex = 8;
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(152, 28);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(216, 38);
            this.studentNameTextBox.TabIndex = 7;
            // 
            // studentPhoneLabel
            // 
            this.studentPhoneLabel.AutoSize = true;
            this.studentPhoneLabel.Location = new System.Drawing.Point(29, 93);
            this.studentPhoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentPhoneLabel.Name = "studentPhoneLabel";
            this.studentPhoneLabel.Size = new System.Drawing.Size(115, 30);
            this.studentPhoneLabel.TabIndex = 6;
            this.studentPhoneLabel.Text = "學生電話:";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(29, 31);
            this.studentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(115, 30);
            this.studentLabel.TabIndex = 5;
            this.studentLabel.Text = "學生姓名:";
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.Location = new System.Drawing.Point(152, 146);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.Size = new System.Drawing.Size(216, 38);
            this.studentIdTextBox.TabIndex = 11;
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Location = new System.Drawing.Point(29, 149);
            this.studentIdLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(92, 30);
            this.studentIdLabel.TabIndex = 10;
            this.studentIdLabel.Text = "學生ID:";
            // 
            // UpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 296);
            this.Controls.Add(this.studentIdTextBox);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.studentPhoneTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentPhoneLabel);
            this.Controls.Add(this.studentLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UpdateUserForm";
            this.Text = "UpdateUserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox studentPhoneTextBox;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label studentPhoneLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.TextBox studentIdTextBox;
        private System.Windows.Forms.Label studentIdLabel;
    }
}