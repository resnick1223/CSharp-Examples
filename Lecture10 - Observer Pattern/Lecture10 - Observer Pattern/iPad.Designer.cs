namespace Lecture10___Observer_Pattern
{
    partial class iPad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimeLabel = new System.Windows.Forms.Label();
            this.StationNameLabel = new System.Windows.Forms.Label();
            this.PressureLabel = new System.Windows.Forms.Label();
            this.HumidityLabel = new System.Windows.Forms.Label();
            this.TemperatureLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(12, 72);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(133, 35);
            this.TimeLabel.TabIndex = 13;
            this.TimeLabel.Text = "更新時間:";
            // 
            // StationNameLabel
            // 
            this.StationNameLabel.AutoSize = true;
            this.StationNameLabel.Location = new System.Drawing.Point(12, 23);
            this.StationNameLabel.Name = "StationNameLabel";
            this.StationNameLabel.Size = new System.Drawing.Size(252, 35);
            this.StationNameLabel.TabIndex = 12;
            this.StationNameLabel.Text = "資料來源: 站台名稱";
            // 
            // PressureLabel
            // 
            this.PressureLabel.AutoSize = true;
            this.PressureLabel.Location = new System.Drawing.Point(427, 120);
            this.PressureLabel.Name = "PressureLabel";
            this.PressureLabel.Size = new System.Drawing.Size(94, 35);
            this.PressureLabel.TabIndex = 11;
            this.PressureLabel.Text = "壓力 0";
            // 
            // HumidityLabel
            // 
            this.HumidityLabel.AutoSize = true;
            this.HumidityLabel.Location = new System.Drawing.Point(222, 120);
            this.HumidityLabel.Name = "HumidityLabel";
            this.HumidityLabel.Size = new System.Drawing.Size(94, 35);
            this.HumidityLabel.TabIndex = 10;
            this.HumidityLabel.Text = "濕度 0";
            // 
            // TemperatureLabel
            // 
            this.TemperatureLabel.AutoSize = true;
            this.TemperatureLabel.Location = new System.Drawing.Point(12, 120);
            this.TemperatureLabel.Name = "TemperatureLabel";
            this.TemperatureLabel.Size = new System.Drawing.Size(129, 35);
            this.TemperatureLabel.TabIndex = 9;
            this.TemperatureLabel.Text = "攝氏 0 度";
            // 
            // iPad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 34F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 220);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.StationNameLabel);
            this.Controls.Add(this.PressureLabel);
            this.Controls.Add(this.HumidityLabel);
            this.Controls.Add(this.TemperatureLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "iPad";
            this.Text = "iPad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label StationNameLabel;
        private System.Windows.Forms.Label PressureLabel;
        private System.Windows.Forms.Label HumidityLabel;
        private System.Windows.Forms.Label TemperatureLabel;
    }
}