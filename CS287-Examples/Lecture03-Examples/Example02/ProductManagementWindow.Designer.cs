namespace Example02
{
    partial class ProductManagementWindow
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
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductCategoryLabel = new System.Windows.Forms.Label();
            this.ProductStatusLabel = new System.Windows.Forms.Label();
            this.ProductCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ProductStatusComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(12, 32);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(35, 24);
            this.ProductIdLabel.TabIndex = 0;
            this.ProductIdLabel.Text = "Id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(119, 29);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(272, 35);
            this.IdTextBox.TabIndex = 1;
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(119, 150);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(272, 35);
            this.ProductPriceTextBox.TabIndex = 3;
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(12, 150);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(63, 24);
            this.ProductPriceLabel.TabIndex = 2;
            this.ProductPriceLabel.Text = "Price:";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(119, 94);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(272, 35);
            this.ProductNameTextBox.TabIndex = 5;
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(12, 94);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(70, 24);
            this.ProductNameLabel.TabIndex = 4;
            this.ProductNameLabel.Text = "Name:";
            // 
            // ProductCategoryLabel
            // 
            this.ProductCategoryLabel.AutoSize = true;
            this.ProductCategoryLabel.Location = new System.Drawing.Point(12, 211);
            this.ProductCategoryLabel.Name = "ProductCategoryLabel";
            this.ProductCategoryLabel.Size = new System.Drawing.Size(98, 24);
            this.ProductCategoryLabel.TabIndex = 6;
            this.ProductCategoryLabel.Text = "Category:";
            // 
            // ProductStatusLabel
            // 
            this.ProductStatusLabel.AutoSize = true;
            this.ProductStatusLabel.Location = new System.Drawing.Point(12, 268);
            this.ProductStatusLabel.Name = "ProductStatusLabel";
            this.ProductStatusLabel.Size = new System.Drawing.Size(71, 24);
            this.ProductStatusLabel.TabIndex = 7;
            this.ProductStatusLabel.Text = "Status:";
            // 
            // ProductCategoryComboBox
            // 
            this.ProductCategoryComboBox.FormattingEnabled = true;
            this.ProductCategoryComboBox.Items.AddRange(new object[] {
            "iPhone",
            "iPad",
            "mac",
            "Watch"});
            this.ProductCategoryComboBox.Location = new System.Drawing.Point(119, 211);
            this.ProductCategoryComboBox.Name = "ProductCategoryComboBox";
            this.ProductCategoryComboBox.Size = new System.Drawing.Size(272, 31);
            this.ProductCategoryComboBox.TabIndex = 8;
            this.ProductCategoryComboBox.Text = "請選擇分類";
            // 
            // ProductStatusComboBox
            // 
            this.ProductStatusComboBox.FormattingEnabled = true;
            this.ProductStatusComboBox.Items.AddRange(new object[] {
            "可訂購",
            "補貨中(無法訂購)",
            "完售(不再進貨)"});
            this.ProductStatusComboBox.Location = new System.Drawing.Point(119, 268);
            this.ProductStatusComboBox.Name = "ProductStatusComboBox";
            this.ProductStatusComboBox.Size = new System.Drawing.Size(272, 31);
            this.ProductStatusComboBox.TabIndex = 9;
            this.ProductStatusComboBox.Text = "請選擇狀態";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(16, 351);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(375, 48);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ProductManagementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 439);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ProductStatusComboBox);
            this.Controls.Add(this.ProductCategoryComboBox);
            this.Controls.Add(this.ProductStatusLabel);
            this.Controls.Add(this.ProductCategoryLabel);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.ProductIdLabel);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductManagementWindow";
            this.Text = "新增產品";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductCategoryLabel;
        private System.Windows.Forms.Label ProductStatusLabel;
        private System.Windows.Forms.ComboBox ProductCategoryComboBox;
        private System.Windows.Forms.ComboBox ProductStatusComboBox;
        private System.Windows.Forms.Button SaveButton;
    }
}