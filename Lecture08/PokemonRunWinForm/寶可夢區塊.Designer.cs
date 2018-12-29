namespace PokemonRunWinForm
{
    partial class 寶可夢區塊
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.血量標籤 = new System.Windows.Forms.Label();
            this.寶可夢圖像 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢圖像)).BeginInit();
            this.SuspendLayout();
            // 
            // 血量標籤
            // 
            this.血量標籤.AutoSize = true;
            this.血量標籤.Location = new System.Drawing.Point(20, 238);
            this.血量標籤.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.血量標籤.Name = "血量標籤";
            this.血量標籤.Size = new System.Drawing.Size(104, 35);
            this.血量標籤.TabIndex = 0;
            this.血量標籤.Text = "HP 0/0";
            // 
            // 寶可夢圖像
            // 
            this.寶可夢圖像.Image = global::PokemonRunWinForm.Properties.Resources._003;
            this.寶可夢圖像.Location = new System.Drawing.Point(3, 3);
            this.寶可夢圖像.Name = "寶可夢圖像";
            this.寶可夢圖像.Size = new System.Drawing.Size(256, 216);
            this.寶可夢圖像.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.寶可夢圖像.TabIndex = 1;
            this.寶可夢圖像.TabStop = false;
            // 
            // 寶可夢區塊
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.寶可夢圖像);
            this.Controls.Add(this.血量標籤);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "寶可夢區塊";
            this.Size = new System.Drawing.Size(353, 364);
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢圖像)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label 血量標籤;
        private System.Windows.Forms.PictureBox 寶可夢圖像;
    }
}
