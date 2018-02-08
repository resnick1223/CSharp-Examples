namespace Example02
{
    partial class StudentDataForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentBirthdayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(33, 41);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(259, 35);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "學生 {0} 的個人資料";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(33, 107);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(118, 35);
            this.studentNameLabel.TabIndex = 1;
            this.studentNameLabel.Text = "姓名: {0}";
            // 
            // studentBirthdayLabel
            // 
            this.studentBirthdayLabel.AutoSize = true;
            this.studentBirthdayLabel.Location = new System.Drawing.Point(33, 174);
            this.studentBirthdayLabel.Name = "studentBirthdayLabel";
            this.studentBirthdayLabel.Size = new System.Drawing.Size(118, 35);
            this.studentBirthdayLabel.TabIndex = 2;
            this.studentBirthdayLabel.Text = "生日: {0}";
            // 
            // StudentDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 240);
            this.Controls.Add(this.studentBirthdayLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "StudentDataForm";
            this.Text = "StudentDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label titleLabel;
        public System.Windows.Forms.Label studentNameLabel;
        public System.Windows.Forms.Label studentBirthdayLabel;
    }
}