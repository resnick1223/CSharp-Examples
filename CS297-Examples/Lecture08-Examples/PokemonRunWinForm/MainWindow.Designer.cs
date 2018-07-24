namespace PokemonRunWinForm
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
            this.components = new System.ComponentModel.Container();
            this.遊戲計時器 = new System.Windows.Forms.Timer(this.components);
            this.寶可夢區塊2 = new PokemonRunWinForm.寶可夢區塊();
            this.寶可夢區塊1 = new PokemonRunWinForm.寶可夢區塊();
            this.SuspendLayout();
            // 
            // 遊戲計時器
            // 
            this.遊戲計時器.Enabled = true;
            this.遊戲計時器.Interval = 1000;
            this.遊戲計時器.Tick += new System.EventHandler(this.遊戲計時器_Tick);
            // 
            // 寶可夢區塊2
            // 
            this.寶可夢區塊2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.寶可夢區塊2.Location = new System.Drawing.Point(417, 37);
            this.寶可夢區塊2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.寶可夢區塊2.Name = "寶可夢區塊2";
            this.寶可夢區塊2.Size = new System.Drawing.Size(291, 330);
            this.寶可夢區塊2.TabIndex = 1;
            this.寶可夢區塊2.Click += new System.EventHandler(this.寶可夢區塊2_Click);
            // 
            // 寶可夢區塊1
            // 
            this.寶可夢區塊1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.寶可夢區塊1.Location = new System.Drawing.Point(15, 37);
            this.寶可夢區塊1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.寶可夢區塊1.Name = "寶可夢區塊1";
            this.寶可夢區塊1.Size = new System.Drawing.Size(291, 330);
            this.寶可夢區塊1.TabIndex = 0;
            this.寶可夢區塊1.Click += new System.EventHandler(this.寶可夢區塊1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.寶可夢區塊2);
            this.Controls.Add(this.寶可夢區塊1);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private 寶可夢區塊 寶可夢區塊1;
        private 寶可夢區塊 寶可夢區塊2;
        private System.Windows.Forms.Timer 遊戲計時器;
    }
}

