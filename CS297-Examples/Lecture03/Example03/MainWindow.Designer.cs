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
            this.components = new System.ComponentModel.Container();
            this.scenePictureBox = new System.Windows.Forms.PictureBox();
            this.travelButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scenePictureBox
            // 
            this.scenePictureBox.Image = global::Example03.Properties.Resources._93d250494f4bae01d615157d8fa791be;
            this.scenePictureBox.Location = new System.Drawing.Point(12, 12);
            this.scenePictureBox.Name = "scenePictureBox";
            this.scenePictureBox.Size = new System.Drawing.Size(639, 426);
            this.scenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scenePictureBox.TabIndex = 0;
            this.scenePictureBox.TabStop = false;
            // 
            // travelButton
            // 
            this.travelButton.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.travelButton.Location = new System.Drawing.Point(670, 13);
            this.travelButton.Name = "travelButton";
            this.travelButton.Size = new System.Drawing.Size(195, 87);
            this.travelButton.TabIndex = 1;
            this.travelButton.Text = "去旅行";
            this.travelButton.UseVisualStyleBackColor = true;
            this.travelButton.Click += new System.EventHandler(this.travelButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 448);
            this.Controls.Add(this.travelButton);
            this.Controls.Add(this.scenePictureBox);
            this.Name = "MainWindow";
            this.Text = "旅青蛙";
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scenePictureBox;
        private System.Windows.Forms.Button travelButton;
        private System.Windows.Forms.Timer gameTimer;
    }
}

