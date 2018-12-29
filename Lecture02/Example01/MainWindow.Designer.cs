namespace Example01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.heightLabel = new System.Windows.Forms.Label();
            this.weightLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(29, 34);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(111, 30);
            this.heightLabel.TabIndex = 0;
            this.heightLabel.Text = "身高(cm)";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(29, 95);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(105, 30);
            this.weightLabel.TabIndex = 1;
            this.weightLabel.Text = "體重(kg)";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(29, 231);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(84, 30);
            this.resultLabel.TabIndex = 2;
            this.resultLabel.Text = "BMI: 0";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(166, 30);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(210, 38);
            this.heightTextBox.TabIndex = 3;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(166, 91);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(210, 38);
            this.weightTextBox.TabIndex = 4;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(34, 155);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(342, 58);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "計算BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 302);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.weightLabel);
            this.Controls.Add(this.heightLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainWindow";
            this.Text = "BMI 計算機";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button calculateButton;
    }
}

