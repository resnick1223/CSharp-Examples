namespace Example02
{
    partial class MainWindow
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
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.studentBirthdayLabel = new System.Windows.Forms.Label();
            this.studentBirthdayTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(197, 51);
            this.studentNameTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(196, 43);
            this.studentNameTextBox.TabIndex = 0;
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(27, 54);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(161, 35);
            this.studentNameLabel.TabIndex = 1;
            this.studentNameLabel.Text = "請輸入姓名:";
            // 
            // studentBirthdayLabel
            // 
            this.studentBirthdayLabel.AutoSize = true;
            this.studentBirthdayLabel.Location = new System.Drawing.Point(27, 131);
            this.studentBirthdayLabel.Name = "studentBirthdayLabel";
            this.studentBirthdayLabel.Size = new System.Drawing.Size(161, 35);
            this.studentBirthdayLabel.TabIndex = 3;
            this.studentBirthdayLabel.Text = "請輸入生日:";
            // 
            // studentBirthdayTextBox
            // 
            this.studentBirthdayTextBox.Location = new System.Drawing.Point(197, 128);
            this.studentBirthdayTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.studentBirthdayTextBox.Name = "studentBirthdayTextBox";
            this.studentBirthdayTextBox.Size = new System.Drawing.Size(196, 43);
            this.studentBirthdayTextBox.TabIndex = 2;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(209, 251);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(184, 68);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "建立資料";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 349);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.studentBirthdayLabel);
            this.Controls.Add(this.studentBirthdayTextBox);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.studentNameTextBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label studentBirthdayLabel;
        private System.Windows.Forms.TextBox studentBirthdayTextBox;
        private System.Windows.Forms.Button createButton;
    }
}

