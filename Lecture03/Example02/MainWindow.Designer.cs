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
            this.CreateStudentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateStudentButton
            // 
            this.CreateStudentButton.Location = new System.Drawing.Point(46, 34);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(274, 105);
            this.CreateStudentButton.TabIndex = 0;
            this.CreateStudentButton.Text = "建立學生";
            this.CreateStudentButton.UseVisualStyleBackColor = true;
            this.CreateStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 181);
            this.Controls.Add(this.CreateStudentButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateStudentButton;
    }
}

