namespace WindowsFormsApp1
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
            this.pokemonNameLabel = new System.Windows.Forms.Label();
            this.powerUpButton = new System.Windows.Forms.Button();
            this.playerInfoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pokemonNameLabel
            // 
            this.pokemonNameLabel.AutoSize = true;
            this.pokemonNameLabel.Location = new System.Drawing.Point(79, 82);
            this.pokemonNameLabel.Name = "pokemonNameLabel";
            this.pokemonNameLabel.Size = new System.Drawing.Size(118, 35);
            this.pokemonNameLabel.TabIndex = 0;
            this.pokemonNameLabel.Text = "名稱: {0}";
            // 
            // powerUpButton
            // 
            this.powerUpButton.Location = new System.Drawing.Point(56, 322);
            this.powerUpButton.Name = "powerUpButton";
            this.powerUpButton.Size = new System.Drawing.Size(161, 57);
            this.powerUpButton.TabIndex = 1;
            this.powerUpButton.Text = "強化";
            this.powerUpButton.UseVisualStyleBackColor = true;
            this.powerUpButton.Click += new System.EventHandler(this.powerUpButton_Click);
            // 
            // playerInfoLabel
            // 
            this.playerInfoLabel.AutoSize = true;
            this.playerInfoLabel.Location = new System.Drawing.Point(79, 138);
            this.playerInfoLabel.Name = "playerInfoLabel";
            this.playerInfoLabel.Size = new System.Drawing.Size(340, 35);
            this.playerInfoLabel.TabIndex = 2;
            this.playerInfoLabel.Text = "玩家的星塵 {0}, {1}糖果 {2}";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 573);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerInfoLabel);
            this.Controls.Add(this.powerUpButton);
            this.Controls.Add(this.pokemonNameLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pokemonNameLabel;
        private System.Windows.Forms.Button powerUpButton;
        private System.Windows.Forms.Label playerInfoLabel;
        private System.Windows.Forms.Label label2;
    }
}

