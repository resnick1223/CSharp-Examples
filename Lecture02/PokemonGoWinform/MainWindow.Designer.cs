namespace PokemonGoWinform
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
            this.cpLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.hpLabel = new System.Windows.Forms.Label();
            this.powerUpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cpLabel
            // 
            this.cpLabel.AutoSize = true;
            this.cpLabel.Location = new System.Drawing.Point(29, 32);
            this.cpLabel.Name = "cpLabel";
            this.cpLabel.Size = new System.Drawing.Size(51, 35);
            this.cpLabel.TabIndex = 0;
            this.cpLabel.Text = "CP";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(29, 93);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(95, 35);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // hpLabel
            // 
            this.hpLabel.AutoSize = true;
            this.hpLabel.Location = new System.Drawing.Point(29, 163);
            this.hpLabel.Name = "hpLabel";
            this.hpLabel.Size = new System.Drawing.Size(187, 35);
            this.hpLabel.TabIndex = 2;
            this.hpLabel.Text = "Hp (100/100)";
            // 
            // powerUpButton
            // 
            this.powerUpButton.Location = new System.Drawing.Point(35, 249);
            this.powerUpButton.Name = "powerUpButton";
            this.powerUpButton.Size = new System.Drawing.Size(221, 59);
            this.powerUpButton.TabIndex = 3;
            this.powerUpButton.Text = "Power Up";
            this.powerUpButton.UseVisualStyleBackColor = true;
            this.powerUpButton.Click += new System.EventHandler(this.powerUpButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 579);
            this.Controls.Add(this.powerUpButton);
            this.Controls.Add(this.hpLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cpLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cpLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label hpLabel;
        private System.Windows.Forms.Button powerUpButton;
    }
}

