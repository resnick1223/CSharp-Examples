namespace Example03
{
    partial class MainForm
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
            this.weatherDataPanel = new System.Windows.Forms.Panel();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.weatherDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // weatherDataPanel
            // 
            this.weatherDataPanel.Controls.Add(this.pressureLabel);
            this.weatherDataPanel.Controls.Add(this.humidityLabel);
            this.weatherDataPanel.Controls.Add(this.temperatureLabel);
            this.weatherDataPanel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.weatherDataPanel.Location = new System.Drawing.Point(27, 32);
            this.weatherDataPanel.Name = "weatherDataPanel";
            this.weatherDataPanel.Size = new System.Drawing.Size(280, 268);
            this.weatherDataPanel.TabIndex = 0;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Location = new System.Drawing.Point(43, 156);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(87, 30);
            this.pressureLabel.TabIndex = 2;
            this.pressureLabel.Text = "壓力: 0";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Location = new System.Drawing.Point(43, 108);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(87, 30);
            this.humidityLabel.TabIndex = 1;
            this.humidityLabel.Text = "濕度: 0";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(43, 58);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(87, 30);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "溫度: 0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 346);
            this.Controls.Add(this.weatherDataPanel);
            this.Name = "MainForm";
            this.Text = "不準確觀測站";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.weatherDataPanel.ResumeLayout(false);
            this.weatherDataPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel weatherDataPanel;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label temperatureLabel;
    }
}

