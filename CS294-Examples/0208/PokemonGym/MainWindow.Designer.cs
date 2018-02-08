namespace PokemonGym
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
            this.components = new System.ComponentModel.Container();
            this.pokemon1PictureBox = new System.Windows.Forms.PictureBox();
            this.pokemon2PictureBox = new System.Windows.Forms.PictureBox();
            this.pokemon1HpLabel = new System.Windows.Forms.Label();
            this.pokemon2HpLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pokemon1HpProgressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon1PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon2PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pokemon1PictureBox
            // 
            this.pokemon1PictureBox.Location = new System.Drawing.Point(51, 34);
            this.pokemon1PictureBox.Name = "pokemon1PictureBox";
            this.pokemon1PictureBox.Size = new System.Drawing.Size(251, 245);
            this.pokemon1PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pokemon1PictureBox.TabIndex = 0;
            this.pokemon1PictureBox.TabStop = false;
            // 
            // pokemon2PictureBox
            // 
            this.pokemon2PictureBox.Location = new System.Drawing.Point(431, 34);
            this.pokemon2PictureBox.Name = "pokemon2PictureBox";
            this.pokemon2PictureBox.Size = new System.Drawing.Size(251, 245);
            this.pokemon2PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pokemon2PictureBox.TabIndex = 1;
            this.pokemon2PictureBox.TabStop = false;
            this.pokemon2PictureBox.Click += new System.EventHandler(this.pokemon2PictureBox_Click);
            // 
            // pokemon1HpLabel
            // 
            this.pokemon1HpLabel.AutoSize = true;
            this.pokemon1HpLabel.Location = new System.Drawing.Point(168, 305);
            this.pokemon1HpLabel.Name = "pokemon1HpLabel";
            this.pokemon1HpLabel.Size = new System.Drawing.Size(14, 15);
            this.pokemon1HpLabel.TabIndex = 2;
            this.pokemon1HpLabel.Text = "0";
            // 
            // pokemon2HpLabel
            // 
            this.pokemon2HpLabel.AutoSize = true;
            this.pokemon2HpLabel.Location = new System.Drawing.Point(537, 305);
            this.pokemon2HpLabel.Name = "pokemon2HpLabel";
            this.pokemon2HpLabel.Size = new System.Drawing.Size(14, 15);
            this.pokemon2HpLabel.TabIndex = 3;
            this.pokemon2HpLabel.Text = "0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pokemon1HpProgressBar
            // 
            this.pokemon1HpProgressBar.Location = new System.Drawing.Point(51, 341);
            this.pokemon1HpProgressBar.Name = "pokemon1HpProgressBar";
            this.pokemon1HpProgressBar.Size = new System.Drawing.Size(251, 23);
            this.pokemon1HpProgressBar.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 445);
            this.Controls.Add(this.pokemon1HpProgressBar);
            this.Controls.Add(this.pokemon2HpLabel);
            this.Controls.Add(this.pokemon1HpLabel);
            this.Controls.Add(this.pokemon2PictureBox);
            this.Controls.Add(this.pokemon1PictureBox);
            this.Name = "MainWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokemon1PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pokemon2PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pokemon1PictureBox;
        private System.Windows.Forms.PictureBox pokemon2PictureBox;
        private System.Windows.Forms.Label pokemon1HpLabel;
        private System.Windows.Forms.Label pokemon2HpLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.ProgressBar pokemon1HpProgressBar;
    }
}

