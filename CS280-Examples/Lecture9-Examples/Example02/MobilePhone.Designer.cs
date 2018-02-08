namespace Example02
{
    partial class MobilePhone
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
            this.pressureTextBox = new System.Windows.Forms.TextBox();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.pressureLabel = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pressureTextBox
            // 
            this.pressureTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pressureTextBox.Location = new System.Drawing.Point(151, 138);
            this.pressureTextBox.Name = "pressureTextBox";
            this.pressureTextBox.Size = new System.Drawing.Size(100, 34);
            this.pressureTextBox.TabIndex = 8;
            // 
            // tempTextBox
            // 
            this.tempTextBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tempTextBox.Location = new System.Drawing.Point(36, 138);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(100, 34);
            this.tempTextBox.TabIndex = 7;
            // 
            // pressureLabel
            // 
            this.pressureLabel.AutoSize = true;
            this.pressureLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pressureLabel.Location = new System.Drawing.Point(146, 80);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(90, 25);
            this.pressureLabel.TabIndex = 6;
            this.pressureLabel.Text = "Pressure";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tempLabel.Location = new System.Drawing.Point(31, 80);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(66, 25);
            this.tempLabel.TabIndex = 5;
            this.tempLabel.Text = "Temp";
            // 
            // dataSourceLabel
            // 
            this.dataSourceLabel.AutoSize = true;
            this.dataSourceLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dataSourceLabel.Location = new System.Drawing.Point(36, 199);
            this.dataSourceLabel.Name = "dataSourceLabel";
            this.dataSourceLabel.Size = new System.Drawing.Size(69, 25);
            this.dataSourceLabel.TabIndex = 9;
            this.dataSourceLabel.Text = "label1";
            // 
            // MobilePhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.dataSourceLabel);
            this.Controls.Add(this.pressureTextBox);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.pressureLabel);
            this.Controls.Add(this.tempLabel);
            this.Name = "MobilePhone";
            this.Text = "MobilePhone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pressureTextBox;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.Label pressureLabel;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label dataSourceLabel;
    }
}