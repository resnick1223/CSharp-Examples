namespace Example03
{
    partial class Form1
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
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.equalLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.execButton = new System.Windows.Forms.Button();
            this.execAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(12, 49);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(120, 25);
            this.number1TextBox.TabIndex = 0;
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(178, 49);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(120, 25);
            this.number2TextBox.TabIndex = 1;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Location = new System.Drawing.Point(147, 54);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(15, 15);
            this.addLabel.TabIndex = 2;
            this.addLabel.Text = "+";
            // 
            // equalLabel
            // 
            this.equalLabel.AutoSize = true;
            this.equalLabel.Location = new System.Drawing.Point(318, 54);
            this.equalLabel.Name = "equalLabel";
            this.equalLabel.Size = new System.Drawing.Size(15, 15);
            this.equalLabel.TabIndex = 3;
            this.equalLabel.Text = "=";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(354, 49);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(120, 25);
            this.resultTextBox.TabIndex = 4;
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(13, 96);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(461, 68);
            this.execButton.TabIndex = 5;
            this.execButton.Text = "執行加法";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // execAddButton
            // 
            this.execAddButton.Location = new System.Drawing.Point(13, 182);
            this.execAddButton.Name = "execAddButton";
            this.execAddButton.Size = new System.Drawing.Size(461, 68);
            this.execAddButton.TabIndex = 6;
            this.execAddButton.Text = "執行真加法";
            this.execAddButton.UseVisualStyleBackColor = true;
            this.execAddButton.Click += new System.EventHandler(this.execAddButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 286);
            this.Controls.Add(this.execAddButton);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.equalLabel);
            this.Controls.Add(this.addLabel);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Name = "Form1";
            this.Text = "Example 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Label equalLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button execAddButton;
    }
}

