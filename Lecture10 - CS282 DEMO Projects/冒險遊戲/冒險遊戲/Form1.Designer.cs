namespace 冒險遊戲
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.HpLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.RestartButton = new System.Windows.Forms.Button();
            this.EndButton = new System.Windows.Forms.Button();
            this.Box = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: Player";
            // 
            // HpLabel
            // 
            this.HpLabel.AutoSize = true;
            this.HpLabel.Location = new System.Drawing.Point(12, 84);
            this.HpLabel.Name = "HpLabel";
            this.HpLabel.Size = new System.Drawing.Size(54, 15);
            this.HpLabel.TabIndex = 1;
            this.HpLabel.Text = "HP: 100";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(12, 135);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(111, 15);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "前進30次後結束";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(60, 368);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(107, 59);
            this.GoButton.TabIndex = 3;
            this.GoButton.Text = "前進";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // RestartButton
            // 
            this.RestartButton.Location = new System.Drawing.Point(255, 368);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(107, 59);
            this.RestartButton.TabIndex = 4;
            this.RestartButton.Text = "重新開始";
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(444, 368);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(107, 59);
            this.EndButton.TabIndex = 5;
            this.EndButton.Text = "結束";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // Box
            // 
            this.Box.Location = new System.Drawing.Point(177, 33);
            this.Box.Multiline = true;
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(374, 311);
            this.Box.TabIndex = 6;
            this.Box.Text = "\r\n";
            this.Box.TextChanged += new System.EventHandler(this.Box_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 447);
            this.Controls.Add(this.Box);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.HpLabel);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "冒險遊戲";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HpLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.TextBox Box;
    }
}

