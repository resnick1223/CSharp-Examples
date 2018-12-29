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
            this.changeHpButton = new System.Windows.Forms.Button();
            this.hpLabel = new System.Windows.Forms.Label();
            this.createNewWindowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // changeHpButton
            // 
            this.changeHpButton.Location = new System.Drawing.Point(44, 134);
            this.changeHpButton.Name = "changeHpButton";
            this.changeHpButton.Size = new System.Drawing.Size(140, 94);
            this.changeHpButton.TabIndex = 0;
            this.changeHpButton.Text = "改變子視窗HP";
            this.changeHpButton.UseVisualStyleBackColor = true;
            this.changeHpButton.Click += new System.EventHandler(this.changeHpButton_Click);
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(41, 63);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(25, 15);
            this.hpLabel.TabIndex = 1;
            this.hpLabel.Text = "HP";
            // 
            // createNewWindowButton
            // 
            this.createNewWindowButton.Location = new System.Drawing.Point(211, 134);
            this.createNewWindowButton.Name = "createNewWindowButton";
            this.createNewWindowButton.Size = new System.Drawing.Size(158, 94);
            this.createNewWindowButton.TabIndex = 2;
            this.createNewWindowButton.Text = "產生子視窗";
            this.createNewWindowButton.UseVisualStyleBackColor = true;
            this.createNewWindowButton.Click += new System.EventHandler(this.createNewWindowButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 275);
            this.Controls.Add(this.createNewWindowButton);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.changeHpButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changeHpButton;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Button createNewWindowButton;
    }
}

