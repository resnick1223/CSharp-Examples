namespace Example05
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
            this.PokemonPowerUpButton = new System.Windows.Forms.Button();
            this.PokemonNameLabel = new System.Windows.Forms.Label();
            this.PokemonHPLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PokemonPowerUpButton
            // 
            this.PokemonPowerUpButton.Location = new System.Drawing.Point(299, 35);
            this.PokemonPowerUpButton.Name = "PokemonPowerUpButton";
            this.PokemonPowerUpButton.Size = new System.Drawing.Size(225, 84);
            this.PokemonPowerUpButton.TabIndex = 0;
            this.PokemonPowerUpButton.Text = "強化";
            this.PokemonPowerUpButton.UseVisualStyleBackColor = true;
            this.PokemonPowerUpButton.Click += new System.EventHandler(this.PokemonPowerUpButton_Click);
            // 
            // PokemonNameLabel
            // 
            this.PokemonNameLabel.AutoSize = true;
            this.PokemonNameLabel.Location = new System.Drawing.Point(29, 27);
            this.PokemonNameLabel.Name = "PokemonNameLabel";
            this.PokemonNameLabel.Size = new System.Drawing.Size(41, 15);
            this.PokemonNameLabel.TabIndex = 1;
            this.PokemonNameLabel.Text = "label1";
            // 
            // PokemonHPLabel
            // 
            this.PokemonHPLabel.AutoSize = true;
            this.PokemonHPLabel.Location = new System.Drawing.Point(29, 104);
            this.PokemonHPLabel.Name = "PokemonHPLabel";
            this.PokemonHPLabel.Size = new System.Drawing.Size(41, 15);
            this.PokemonHPLabel.TabIndex = 2;
            this.PokemonHPLabel.Text = "label2";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 159);
            this.Controls.Add(this.PokemonHPLabel);
            this.Controls.Add(this.PokemonNameLabel);
            this.Controls.Add(this.PokemonPowerUpButton);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PokemonPowerUpButton;
        private System.Windows.Forms.Label PokemonNameLabel;
        private System.Windows.Forms.Label PokemonHPLabel;
    }
}

