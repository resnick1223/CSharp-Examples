namespace Example02
{
    partial class Form1
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
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.cashOrSightComboBox = new System.Windows.Forms.ComboBox();
            this.buyOrSellComboBox = new System.Windows.Forms.ComboBox();
            this.queryButton = new System.Windows.Forms.Button();
            this.dataTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Items.AddRange(new object[] {
            "USD",
            "JPY",
            "HKD",
            "AUD",
            "GBP"});
            this.currencyComboBox.Location = new System.Drawing.Point(23, 83);
            this.currencyComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(263, 37);
            this.currencyComboBox.TabIndex = 0;
            this.currencyComboBox.Text = "請選擇幣別";
            this.currencyComboBox.SelectedIndexChanged += new System.EventHandler(this.currencyComboBox_SelectedIndexChanged);
            // 
            // cashOrSightComboBox
            // 
            this.cashOrSightComboBox.FormattingEnabled = true;
            this.cashOrSightComboBox.Items.AddRange(new object[] {
            "現金",
            "即期"});
            this.cashOrSightComboBox.Location = new System.Drawing.Point(299, 83);
            this.cashOrSightComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cashOrSightComboBox.Name = "cashOrSightComboBox";
            this.cashOrSightComboBox.Size = new System.Drawing.Size(209, 37);
            this.cashOrSightComboBox.TabIndex = 1;
            this.cashOrSightComboBox.Text = "選擇現金/即期";
            this.cashOrSightComboBox.SelectedIndexChanged += new System.EventHandler(this.cashOrSightComboBox_SelectedIndexChanged);
            // 
            // buyOrSellComboBox
            // 
            this.buyOrSellComboBox.FormattingEnabled = true;
            this.buyOrSellComboBox.Items.AddRange(new object[] {
            "本行買入",
            "本行賣出"});
            this.buyOrSellComboBox.Location = new System.Drawing.Point(522, 83);
            this.buyOrSellComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buyOrSellComboBox.Name = "buyOrSellComboBox";
            this.buyOrSellComboBox.Size = new System.Drawing.Size(209, 37);
            this.buyOrSellComboBox.TabIndex = 2;
            this.buyOrSellComboBox.Text = "選擇買入/賣出";
            this.buyOrSellComboBox.SelectedIndexChanged += new System.EventHandler(this.buyOrSellComboBox_SelectedIndexChanged);
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(23, 175);
            this.queryButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(173, 49);
            this.queryButton.TabIndex = 3;
            this.queryButton.Text = "查詢";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // dataTimer
            // 
            this.dataTimer.Enabled = true;
            this.dataTimer.Interval = 10000;
            this.dataTimer.Tick += new System.EventHandler(this.FetchData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 283);
            this.Controls.Add(this.queryButton);
            this.Controls.Add(this.buyOrSellComboBox);
            this.Controls.Add(this.cashOrSightComboBox);
            this.Controls.Add(this.currencyComboBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.ComboBox cashOrSightComboBox;
        private System.Windows.Forms.ComboBox buyOrSellComboBox;
        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.Timer dataTimer;
    }
}

