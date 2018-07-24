namespace PokemonGoRunWinForm
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
            this.寶可夢CP標籤 = new System.Windows.Forms.Label();
            this.寶可夢名字標籤 = new System.Windows.Forms.Label();
            this.寶可夢HP標籤 = new System.Windows.Forms.Label();
            this.強化按鈕 = new System.Windows.Forms.Button();
            this.玩家的星星沙子標籤 = new System.Windows.Forms.Label();
            this.玩家的糖果標籤 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // 寶可夢CP標籤
            // 
            this.寶可夢CP標籤.AutoSize = true;
            this.寶可夢CP標籤.Location = new System.Drawing.Point(184, 41);
            this.寶可夢CP標籤.Name = "寶可夢CP標籤";
            this.寶可夢CP標籤.Size = new System.Drawing.Size(58, 15);
            this.寶可夢CP標籤.TabIndex = 0;
            this.寶可夢CP標籤.Text = "CP 標籤";
            // 
            // 寶可夢名字標籤
            // 
            this.寶可夢名字標籤.AutoSize = true;
            this.寶可夢名字標籤.Location = new System.Drawing.Point(184, 88);
            this.寶可夢名字標籤.Name = "寶可夢名字標籤";
            this.寶可夢名字標籤.Size = new System.Drawing.Size(67, 15);
            this.寶可夢名字標籤.TabIndex = 1;
            this.寶可夢名字標籤.Text = "名字標籤";
            // 
            // 寶可夢HP標籤
            // 
            this.寶可夢HP標籤.AutoSize = true;
            this.寶可夢HP標籤.Location = new System.Drawing.Point(187, 163);
            this.寶可夢HP標籤.Name = "寶可夢HP標籤";
            this.寶可夢HP標籤.Size = new System.Drawing.Size(59, 15);
            this.寶可夢HP標籤.TabIndex = 2;
            this.寶可夢HP標籤.Text = "HP 標籤";
            // 
            // 強化按鈕
            // 
            this.強化按鈕.Location = new System.Drawing.Point(55, 378);
            this.強化按鈕.Name = "強化按鈕";
            this.強化按鈕.Size = new System.Drawing.Size(128, 60);
            this.強化按鈕.TabIndex = 3;
            this.強化按鈕.Text = "強化";
            this.強化按鈕.UseVisualStyleBackColor = true;
            this.強化按鈕.Click += new System.EventHandler(this.強化按鈕_Click);
            // 
            // 玩家的星星沙子標籤
            // 
            this.玩家的星星沙子標籤.AutoSize = true;
            this.玩家的星星沙子標籤.Location = new System.Drawing.Point(96, 247);
            this.玩家的星星沙子標籤.Name = "玩家的星星沙子標籤";
            this.玩家的星星沙子標籤.Size = new System.Drawing.Size(112, 15);
            this.玩家的星星沙子標籤.TabIndex = 4;
            this.玩家的星星沙子標籤.Text = "玩家的星星沙子";
            // 
            // 玩家的糖果標籤
            // 
            this.玩家的糖果標籤.AutoSize = true;
            this.玩家的糖果標籤.Location = new System.Drawing.Point(95, 307);
            this.玩家的糖果標籤.Name = "玩家的糖果標籤";
            this.玩家的糖果標籤.Size = new System.Drawing.Size(82, 15);
            this.玩家的糖果標籤.TabIndex = 5;
            this.玩家的糖果標籤.Text = "玩家的糖果";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 565);
            this.Controls.Add(this.玩家的糖果標籤);
            this.Controls.Add(this.玩家的星星沙子標籤);
            this.Controls.Add(this.強化按鈕);
            this.Controls.Add(this.寶可夢HP標籤);
            this.Controls.Add(this.寶可夢名字標籤);
            this.Controls.Add(this.寶可夢CP標籤);
            this.Name = "MainWindow";
            this.Text = "寶可夢跑 視窗版";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 寶可夢CP標籤;
        private System.Windows.Forms.Label 寶可夢名字標籤;
        private System.Windows.Forms.Label 寶可夢HP標籤;
        private System.Windows.Forms.Button 強化按鈕;
        private System.Windows.Forms.Label 玩家的星星沙子標籤;
        private System.Windows.Forms.Label 玩家的糖果標籤;
    }
}

