namespace StudentsAdmin
{
    partial class CreateUserForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            this.studentLabel = new System.Windows.Forms.Label();
            this.studentPhoneLabel = new System.Windows.Forms.Label();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.studentPhoneTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(14, 15);
            this.studentLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(115, 30);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "學生姓名:";
            this.studentLabel.Click += new System.EventHandler(this.studentLabel_Click);
            // 
            // studentPhoneLabel
            // 
            this.studentPhoneLabel.AutoSize = true;
            this.studentPhoneLabel.Location = new System.Drawing.Point(14, 77);
            this.studentPhoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.studentPhoneLabel.Name = "studentPhoneLabel";
            this.studentPhoneLabel.Size = new System.Drawing.Size(115, 30);
            this.studentPhoneLabel.TabIndex = 1;
            this.studentPhoneLabel.Text = "學生電話:";
            this.studentPhoneLabel.Click += new System.EventHandler(this.studentPhoneLabel_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(137, 12);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(216, 38);
            this.studentNameTextBox.TabIndex = 2;
            this.studentNameTextBox.TextChanged += new System.EventHandler(this.studentNameTextBox_TextChanged);
            // 
            // studentPhoneTextBox
            // 
            this.studentPhoneTextBox.Location = new System.Drawing.Point(137, 74);
            this.studentPhoneTextBox.Name = "studentPhoneTextBox";
            this.studentPhoneTextBox.Size = new System.Drawing.Size(216, 38);
            this.studentPhoneTextBox.TabIndex = 3;
            this.studentPhoneTextBox.TextChanged += new System.EventHandler(this.studentPhoneTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(19, 157);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(144, 43);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "新增";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 265);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.studentPhoneTextBox);
            this.Controls.Add(this.studentNameTextBox);
            this.Controls.Add(this.studentPhoneLabel);
            this.Controls.Add(this.studentLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateUserForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label studentPhoneLabel;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.TextBox studentPhoneTextBox;
        private System.Windows.Forms.Button addButton;
    }
}

