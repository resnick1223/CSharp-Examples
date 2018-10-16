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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PowerUpButton = new System.Windows.Forms.Button();
            this.PokemonPictureBox = new System.Windows.Forms.PictureBox();
            this.PokemonCPLabel = new System.Windows.Forms.Label();
            this.PokemonNameLabel = new System.Windows.Forms.Label();
            this.PokemonHeightLabel = new System.Windows.Forms.Label();
            this.PokemonHPLabel = new System.Windows.Forms.Label();
            this.PokemonTypeLabel = new System.Windows.Forms.Label();
            this.PokemonWeightLabel = new System.Windows.Forms.Label();
            this.PlayerStardustLabel = new System.Windows.Forms.Label();
            this.PlayerCandyLabel = new System.Windows.Forms.Label();
            this.PowerUpNeedsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PowerUpButton
            // 
            this.PowerUpButton.Location = new System.Drawing.Point(37, 458);
            this.PowerUpButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PowerUpButton.Name = "PowerUpButton";
            this.PowerUpButton.Size = new System.Drawing.Size(114, 42);
            this.PowerUpButton.TabIndex = 0;
            this.PowerUpButton.Text = "強化";
            this.PowerUpButton.UseVisualStyleBackColor = true;
            this.PowerUpButton.Click += new System.EventHandler(this.PowerUpButton_Click);
            // 
            // PokemonPictureBox
            // 
            this.PokemonPictureBox.Image = global::Example03.Properties.Resources.Zapdos;
            this.PokemonPictureBox.Location = new System.Drawing.Point(100, 16);
            this.PokemonPictureBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.PokemonPictureBox.Name = "PokemonPictureBox";
            this.PokemonPictureBox.Size = new System.Drawing.Size(214, 204);
            this.PokemonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PokemonPictureBox.TabIndex = 1;
            this.PokemonPictureBox.TabStop = false;
            // 
            // PokemonCPLabel
            // 
            this.PokemonCPLabel.AutoSize = true;
            this.PokemonCPLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonCPLabel.Location = new System.Drawing.Point(33, 239);
            this.PokemonCPLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PokemonCPLabel.Name = "PokemonCPLabel";
            this.PokemonCPLabel.Size = new System.Drawing.Size(47, 20);
            this.PokemonCPLabel.TabIndex = 2;
            this.PokemonCPLabel.Text = "CP: 0";
            // 
            // PokemonNameLabel
            // 
            this.PokemonNameLabel.AutoSize = true;
            this.PokemonNameLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonNameLabel.Location = new System.Drawing.Point(33, 275);
            this.PokemonNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PokemonNameLabel.Name = "PokemonNameLabel";
            this.PokemonNameLabel.Size = new System.Drawing.Size(143, 20);
            this.PokemonNameLabel.TabIndex = 3;
            this.PokemonNameLabel.Text = "Name: 寶可夢名稱";
            // 
            // PokemonHeightLabel
            // 
            this.PokemonHeightLabel.AutoSize = true;
            this.PokemonHeightLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonHeightLabel.Location = new System.Drawing.Point(33, 321);
            this.PokemonHeightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PokemonHeightLabel.Name = "PokemonHeightLabel";
            this.PokemonHeightLabel.Size = new System.Drawing.Size(73, 20);
            this.PokemonHeightLabel.TabIndex = 4;
            this.PokemonHeightLabel.Text = "身高: 0m";
            // 
            // PokemonHPLabel
            // 
            this.PokemonHPLabel.AutoSize = true;
            this.PokemonHPLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonHPLabel.Location = new System.Drawing.Point(33, 365);
            this.PokemonHPLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PokemonHPLabel.Name = "PokemonHPLabel";
            this.PokemonHPLabel.Size = new System.Drawing.Size(64, 20);
            this.PokemonHPLabel.TabIndex = 5;
            this.PokemonHPLabel.Text = "HP: 0/0";
            // 
            // PokemonTypeLabel
            // 
            this.PokemonTypeLabel.AutoSize = true;
            this.PokemonTypeLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonTypeLabel.Location = new System.Drawing.Point(187, 365);
            this.PokemonTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PokemonTypeLabel.Name = "PokemonTypeLabel";
            this.PokemonTypeLabel.Size = new System.Drawing.Size(57, 20);
            this.PokemonTypeLabel.TabIndex = 6;
            this.PokemonTypeLabel.Text = "類型: ?";
            // 
            // PokemonWeightLabel
            // 
            this.PokemonWeightLabel.AutoSize = true;
            this.PokemonWeightLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PokemonWeightLabel.Location = new System.Drawing.Point(187, 321);
            this.PokemonWeightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PokemonWeightLabel.Name = "PokemonWeightLabel";
            this.PokemonWeightLabel.Size = new System.Drawing.Size(77, 20);
            this.PokemonWeightLabel.TabIndex = 7;
            this.PokemonWeightLabel.Text = "體重: 0kg";
            // 
            // PlayerStardustLabel
            // 
            this.PlayerStardustLabel.AutoSize = true;
            this.PlayerStardustLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayerStardustLabel.Location = new System.Drawing.Point(33, 417);
            this.PlayerStardustLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PlayerStardustLabel.Name = "PlayerStardustLabel";
            this.PlayerStardustLabel.Size = new System.Drawing.Size(90, 20);
            this.PlayerStardustLabel.TabIndex = 8;
            this.PlayerStardustLabel.Text = "星星沙子: 0";
            // 
            // PlayerCandyLabel
            // 
            this.PlayerCandyLabel.AutoSize = true;
            this.PlayerCandyLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PlayerCandyLabel.Location = new System.Drawing.Point(187, 417);
            this.PlayerCandyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PlayerCandyLabel.Name = "PlayerCandyLabel";
            this.PlayerCandyLabel.Size = new System.Drawing.Size(106, 20);
            this.PlayerCandyLabel.TabIndex = 9;
            this.PlayerCandyLabel.Text = "寶可夢糖果: 0";
            // 
            // PowerUpNeedsLabel
            // 
            this.PowerUpNeedsLabel.AutoSize = true;
            this.PowerUpNeedsLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PowerUpNeedsLabel.Location = new System.Drawing.Point(187, 471);
            this.PowerUpNeedsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PowerUpNeedsLabel.Name = "PowerUpNeedsLabel";
            this.PowerUpNeedsLabel.Size = new System.Drawing.Size(199, 20);
            this.PowerUpNeedsLabel.TabIndex = 10;
            this.PowerUpNeedsLabel.Text = "星星沙子: 0, 寶可夢糖果: 0 ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 589);
            this.Controls.Add(this.PowerUpNeedsLabel);
            this.Controls.Add(this.PlayerCandyLabel);
            this.Controls.Add(this.PlayerStardustLabel);
            this.Controls.Add(this.PokemonWeightLabel);
            this.Controls.Add(this.PokemonTypeLabel);
            this.Controls.Add(this.PokemonHPLabel);
            this.Controls.Add(this.PokemonHeightLabel);
            this.Controls.Add(this.PokemonNameLabel);
            this.Controls.Add(this.PokemonCPLabel);
            this.Controls.Add(this.PokemonPictureBox);
            this.Controls.Add(this.PowerUpButton);
            this.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainWindow";
            this.Text = "Pokemon GO GO";
            ((System.ComponentModel.ISupportInitialize)(this.PokemonPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PowerUpButton;
        private System.Windows.Forms.PictureBox PokemonPictureBox;
        private System.Windows.Forms.Label PokemonCPLabel;
        private System.Windows.Forms.Label PokemonNameLabel;
        private System.Windows.Forms.Label PokemonHeightLabel;
        private System.Windows.Forms.Label PokemonHPLabel;
        private System.Windows.Forms.Label PokemonTypeLabel;
        private System.Windows.Forms.Label PokemonWeightLabel;
        private System.Windows.Forms.Label PlayerStardustLabel;
        private System.Windows.Forms.Label PlayerCandyLabel;
        private System.Windows.Forms.Label PowerUpNeedsLabel;
    }
}

