namespace ObserverPatternExample
{
    partial class WeatherStation
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
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.stationNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataTimer
            // 
            this.dataTimer.Interval = 500;
            this.dataTimer.Tick += new System.EventHandler(this.dataTimer_Tick);
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.temperatureLabel.Location = new System.Drawing.Point(52, 54);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(117, 30);
            this.temperatureLabel.TabIndex = 0;
            this.temperatureLabel.Text = "溫度: 0 度";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(45, 190);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(144, 56);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "接收資料";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pressureLabel.Location = new System.Drawing.Point(382, 54);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(165, 30);
            this.pressureLabel.TabIndex = 2;
            this.pressureLabel.Text = "壓力: 0 大氣壓";
            // 
            // humidityLabel
            // 
            this.humidityLabel.AutoSize = true;
            this.humidityLabel.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.humidityLabel.Location = new System.Drawing.Point(223, 54);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(114, 30);
            this.humidityLabel.TabIndex = 3;
            this.humidityLabel.Text = "濕度: 0 %";
            // 
            // stationNameLabel
            // 
            this.stationNameLabel.AutoSize = true;
            this.stationNameLabel.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.stationNameLabel.Location = new System.Drawing.Point(53, 121);
            this.stationNameLabel.Name = "stationNameLabel";
            this.stationNameLabel.Size = new System.Drawing.Size(106, 24);
            this.stationNameLabel.TabIndex = 4;
            this.stationNameLabel.Text = "觀測站名";
            // 
            // WeatherStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 305);
            this.Controls.Add(this.stationNameLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.temperatureLabel);
            this.Name = "WeatherStation";
            this.Text = "氣象站 資料產生器";
            this.Load += new System.EventHandler(this.WeatherStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer dataTimer;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label stationNameLabel;
    }
}

