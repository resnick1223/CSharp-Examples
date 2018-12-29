namespace Example02
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.ShoppingCartRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Product1Label = new System.Windows.Forms.Label();
            this.Product2Label = new System.Windows.Forms.Label();
            this.AddProduct1Button = new System.Windows.Forms.Button();
            this.AddProduct2Button = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ProductMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProductMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShoppingCartRichTextBox
            // 
            this.ShoppingCartRichTextBox.Location = new System.Drawing.Point(12, 215);
            this.ShoppingCartRichTextBox.Name = "ShoppingCartRichTextBox";
            this.ShoppingCartRichTextBox.Size = new System.Drawing.Size(541, 202);
            this.ShoppingCartRichTextBox.TabIndex = 0;
            this.ShoppingCartRichTextBox.Text = "";
            // 
            // Product1Label
            // 
            this.Product1Label.AutoSize = true;
            this.Product1Label.BackColor = System.Drawing.SystemColors.Control;
            this.Product1Label.Location = new System.Drawing.Point(22, 44);
            this.Product1Label.Name = "Product1Label";
            this.Product1Label.Size = new System.Drawing.Size(151, 24);
            this.Product1Label.TabIndex = 1;
            this.Product1Label.Text = "Product1 Name";
            this.Product1Label.Click += new System.EventHandler(this.Product1Label_Click);
            // 
            // Product2Label
            // 
            this.Product2Label.AutoSize = true;
            this.Product2Label.Location = new System.Drawing.Point(22, 107);
            this.Product2Label.Name = "Product2Label";
            this.Product2Label.Size = new System.Drawing.Size(151, 24);
            this.Product2Label.TabIndex = 2;
            this.Product2Label.Text = "Product2 Name";
            // 
            // AddProduct1Button
            // 
            this.AddProduct1Button.Location = new System.Drawing.Point(357, 30);
            this.AddProduct1Button.Name = "AddProduct1Button";
            this.AddProduct1Button.Size = new System.Drawing.Size(196, 50);
            this.AddProduct1Button.TabIndex = 3;
            this.AddProduct1Button.Text = "加入購物清單";
            this.AddProduct1Button.UseVisualStyleBackColor = true;
            this.AddProduct1Button.Click += new System.EventHandler(this.AddProduct1Button_Click);
            // 
            // AddProduct2Button
            // 
            this.AddProduct2Button.Location = new System.Drawing.Point(355, 93);
            this.AddProduct2Button.Name = "AddProduct2Button";
            this.AddProduct2Button.Size = new System.Drawing.Size(196, 50);
            this.AddProduct2Button.TabIndex = 4;
            this.AddProduct2Button.Text = "加入購物清單";
            this.AddProduct2Button.UseVisualStyleBackColor = true;
            this.AddProduct2Button.Click += new System.EventHandler(this.AddProduct2Button_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(13, 444);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(88, 24);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "總金額:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(357, 163);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(196, 46);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "清空購物車";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ProductMainMenuStrip
            // 
            this.ProductMainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ProductMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProductMenuItem});
            this.ProductMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductMainMenuStrip.Name = "ProductMainMenuStrip";
            this.ProductMainMenuStrip.Size = new System.Drawing.Size(563, 28);
            this.ProductMainMenuStrip.TabIndex = 7;
            this.ProductMainMenuStrip.Text = "menuStrip1";
            // 
            // ProductMenuItem
            // 
            this.ProductMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductMenuItem});
            this.ProductMenuItem.Name = "ProductMenuItem";
            this.ProductMenuItem.Size = new System.Drawing.Size(85, 24);
            this.ProductMenuItem.Text = "產品管理";
            // 
            // AddProductMenuItem
            // 
            this.AddProductMenuItem.Name = "AddProductMenuItem";
            this.AddProductMenuItem.Size = new System.Drawing.Size(181, 26);
            this.AddProductMenuItem.Text = "新增產品";
            this.AddProductMenuItem.Click += new System.EventHandler(this.AddProductMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 494);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.AddProduct2Button);
            this.Controls.Add(this.AddProduct1Button);
            this.Controls.Add(this.Product2Label);
            this.Controls.Add(this.Product1Label);
            this.Controls.Add(this.ShoppingCartRichTextBox);
            this.Controls.Add(this.ProductMainMenuStrip);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ProductMainMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "歡迎光臨Apple Store";
            this.ProductMainMenuStrip.ResumeLayout(false);
            this.ProductMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ShoppingCartRichTextBox;
        private System.Windows.Forms.Label Product1Label;
        private System.Windows.Forms.Label Product2Label;
        private System.Windows.Forms.Button AddProduct1Button;
        private System.Windows.Forms.Button AddProduct2Button;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.MenuStrip ProductMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ProductMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddProductMenuItem;
    }
}

