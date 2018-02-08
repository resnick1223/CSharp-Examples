namespace Example03
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.product1Button = new System.Windows.Forms.Button();
            this.product2Button = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.orderRichTextBox = new System.Windows.Forms.RichTextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.accoutButton = new System.Windows.Forms.Button();
            this.tableComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // product1Button
            // 
            this.product1Button.Location = new System.Drawing.Point(29, 89);
            this.product1Button.Name = "product1Button";
            this.product1Button.Size = new System.Drawing.Size(109, 72);
            this.product1Button.TabIndex = 0;
            this.product1Button.Text = "button1";
            this.product1Button.UseVisualStyleBackColor = true;
            this.product1Button.Click += new System.EventHandler(this.product1Button_Click);
            // 
            // product2Button
            // 
            this.product2Button.Location = new System.Drawing.Point(156, 89);
            this.product2Button.Name = "product2Button";
            this.product2Button.Size = new System.Drawing.Size(109, 72);
            this.product2Button.TabIndex = 1;
            this.product2Button.Text = "button2";
            this.product2Button.UseVisualStyleBackColor = true;
            this.product2Button.Click += new System.EventHandler(this.product2Button_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(314, 39);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(46, 16);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "label1";
            // 
            // orderRichTextBox
            // 
            this.orderRichTextBox.Location = new System.Drawing.Point(32, 185);
            this.orderRichTextBox.Name = "orderRichTextBox";
            this.orderRichTextBox.Size = new System.Drawing.Size(427, 166);
            this.orderRichTextBox.TabIndex = 3;
            this.orderRichTextBox.Text = "";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(156, 12);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(109, 71);
            this.orderButton.TabIndex = 4;
            this.orderButton.Text = "button1";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // accoutButton
            // 
            this.accoutButton.Location = new System.Drawing.Point(282, 89);
            this.accoutButton.Name = "accoutButton";
            this.accoutButton.Size = new System.Drawing.Size(120, 72);
            this.accoutButton.TabIndex = 5;
            this.accoutButton.Text = "button1";
            this.accoutButton.UseVisualStyleBackColor = true;
            this.accoutButton.Click += new System.EventHandler(this.accoutButton_Click);
            // 
            // tableComboBox
            // 
            this.tableComboBox.FormattingEnabled = true;
            this.tableComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.tableComboBox.Location = new System.Drawing.Point(29, 12);
            this.tableComboBox.Name = "tableComboBox";
            this.tableComboBox.Size = new System.Drawing.Size(121, 24);
            this.tableComboBox.TabIndex = 6;
            this.tableComboBox.SelectedIndexChanged += new System.EventHandler(this.tableComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 380);
            this.Controls.Add(this.tableComboBox);
            this.Controls.Add(this.accoutButton);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.orderRichTextBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.product2Button);
            this.Controls.Add(this.product1Button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button product1Button;
        private System.Windows.Forms.Button product2Button;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.RichTextBox orderRichTextBox;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Button accoutButton;
        private System.Windows.Forms.ComboBox tableComboBox;
    }
}

