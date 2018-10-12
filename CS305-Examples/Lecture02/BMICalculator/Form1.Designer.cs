namespace BMICalculator
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
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(15, 42);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(129, 35);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "身高(cm)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(15, 102);
            this.weightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(122, 35);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "體重(kg)";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(181, 42);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(221, 43);
            this.heightTextBox.TabIndex = 2;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(181, 102);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.PasswordChar = '-';
            this.weightTextBox.Size = new System.Drawing.Size(221, 43);
            this.weightTextBox.TabIndex = 3;
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultRichTextBox.Location = new System.Drawing.Point(21, 234);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(381, 196);
            this.resultRichTextBox.TabIndex = 4;
            this.resultRichTextBox.Text = "";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(21, 163);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(381, 65);
            this.calcButton.TabIndex = 5;
            this.calcButton.Text = "計算BMI";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 442);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultRichTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Button calcButton;
    }
}

