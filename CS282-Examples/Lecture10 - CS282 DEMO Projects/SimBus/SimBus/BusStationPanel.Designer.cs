namespace SimBus
{
    partial class BusStationPanel
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusStationPanel));
            this.BusStationNameLabel = new System.Windows.Forms.Label();
            this.BusStationKMLabel = new System.Windows.Forms.Label();
            this.BusTimeLabel = new System.Windows.Forms.Label();
            this.BusPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BusPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BusStationNameLabel
            // 
            this.BusStationNameLabel.AutoSize = true;
            this.BusStationNameLabel.Location = new System.Drawing.Point(3, 16);
            this.BusStationNameLabel.Name = "BusStationNameLabel";
            this.BusStationNameLabel.Size = new System.Drawing.Size(88, 13);
            this.BusStationNameLabel.TabIndex = 0;
            this.BusStationNameLabel.Text = "BusStationName";
            // 
            // BusStationKMLabel
            // 
            this.BusStationKMLabel.AutoSize = true;
            this.BusStationKMLabel.Location = new System.Drawing.Point(67, 16);
            this.BusStationKMLabel.Name = "BusStationKMLabel";
            this.BusStationKMLabel.Size = new System.Drawing.Size(79, 13);
            this.BusStationKMLabel.TabIndex = 1;
            this.BusStationKMLabel.Text = "BusStationKM";
            // 
            // BusTimeLabel
            // 
            this.BusTimeLabel.AutoSize = true;
            this.BusTimeLabel.Location = new System.Drawing.Point(138, 16);
            this.BusTimeLabel.Name = "BusTimeLabel";
            this.BusTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.BusTimeLabel.TabIndex = 2;
            this.BusTimeLabel.Text = "BusTime";
            // 
            // BusPictureBox
            // 
            this.BusPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("BusPictureBox.Image")));
            this.BusPictureBox.Location = new System.Drawing.Point(195, 0);
            this.BusPictureBox.Name = "BusPictureBox";
            this.BusPictureBox.Size = new System.Drawing.Size(32, 42);
            this.BusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BusPictureBox.TabIndex = 3;
            this.BusPictureBox.TabStop = false;
            // 
            // BusStationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.BusPictureBox);
            this.Controls.Add(this.BusTimeLabel);
            this.Controls.Add(this.BusStationKMLabel);
            this.Controls.Add(this.BusStationNameLabel);
            this.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "BusStationPanel";
            this.Size = new System.Drawing.Size(239, 45);
            ((System.ComponentModel.ISupportInitialize)(this.BusPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BusStationNameLabel;
        private System.Windows.Forms.Label BusStationKMLabel;
        private System.Windows.Forms.Label BusTimeLabel;
        private System.Windows.Forms.PictureBox BusPictureBox;
    }
}
