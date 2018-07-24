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
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.bmiLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weightTextBox
            // 
            this.weightTextBox.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightTextBox.Location = new System.Drawing.Point(61, 43);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(164, 43);
            this.weightTextBox.TabIndex = 0;
            // 
            // heightTextBox
            // 
            this.heightTextBox.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.heightTextBox.Location = new System.Drawing.Point(61, 113);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(164, 43);
            this.heightTextBox.TabIndex = 1;
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weightLabel.Location = new System.Drawing.Point(243, 51);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(48, 35);
            this.weightLabel.TabIndex = 2;
            this.weightLabel.Text = "kg";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.heightLabel.Location = new System.Drawing.Point(243, 116);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(55, 35);
            this.heightLabel.TabIndex = 3;
            this.heightLabel.Text = "cm";
            // 
            // bmiLabel
            // 
            this.bmiLabel.AutoSize = true;
            this.bmiLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bmiLabel.Location = new System.Drawing.Point(61, 206);
            this.bmiLabel.Name = "bmiLabel";
            this.bmiLabel.Size = new System.Drawing.Size(96, 35);
            this.bmiLabel.TabIndex = 4;
            this.bmiLabel.Text = "BMI: 0";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resultLabel.Location = new System.Drawing.Point(246, 205);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(211, 35);
            this.resultLabel.TabIndex = 5;
            this.resultLabel.Text = "請輸入身高體重";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(61, 271);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(164, 46);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "計算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 343);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.bmiLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label bmiLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

