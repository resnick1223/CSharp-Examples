namespace Example03
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
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(220, 41);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(196, 38);
            this.HeightTextBox.TabIndex = 0;
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(220, 124);
            this.WeightTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(196, 38);
            this.WeightTextBox.TabIndex = 1;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(46, 48);
            this.HeightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(134, 32);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "身高(cm):";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(46, 130);
            this.WeightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(119, 32);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "體重(kg)";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(52, 261);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(368, 58);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "計算BMI";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(46, 191);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(95, 32);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "BMI: 0";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 347);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainWindow";
            this.Text = "BMI 計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ResultLabel;
    }
}

