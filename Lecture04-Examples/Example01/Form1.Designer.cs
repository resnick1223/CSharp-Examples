namespace Example01
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.scenePictureBox = new System.Windows.Forms.PictureBox();
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // scenePictureBox
            // 
            this.scenePictureBox.Image = global::Example01.Properties.Resources._1;
            this.scenePictureBox.Location = new System.Drawing.Point(23, 12);
            this.scenePictureBox.Name = "scenePictureBox";
            this.scenePictureBox.Size = new System.Drawing.Size(482, 476);
            this.scenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.scenePictureBox.TabIndex = 0;
            this.scenePictureBox.TabStop = false;
            // 
            // yesButton
            // 
            this.yesButton.Location = new System.Drawing.Point(12, 513);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(253, 55);
            this.yesButton.TabIndex = 1;
            this.yesButton.Text = "我選 1";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Location = new System.Drawing.Point(271, 513);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(253, 55);
            this.noButton.TabIndex = 2;
            this.noButton.Text = "我選 2";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 580);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.scenePictureBox);
            this.Name = "Form1";
            this.Text = "上班族心事蝦郎災";
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scenePictureBox;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
    }
}

