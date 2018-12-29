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
            this.resultRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sortByXButton = new System.Windows.Forms.Button();
            this.sortByYButton = new System.Windows.Forms.Button();
            this.sortByLengthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultRichTextBox
            // 
            this.resultRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultRichTextBox.Location = new System.Drawing.Point(12, 100);
            this.resultRichTextBox.Name = "resultRichTextBox";
            this.resultRichTextBox.Size = new System.Drawing.Size(605, 325);
            this.resultRichTextBox.TabIndex = 0;
            this.resultRichTextBox.Text = "";
            // 
            // sortByXButton
            // 
            this.sortByXButton.Location = new System.Drawing.Point(12, 12);
            this.sortByXButton.Name = "sortByXButton";
            this.sortByXButton.Size = new System.Drawing.Size(144, 69);
            this.sortByXButton.TabIndex = 1;
            this.sortByXButton.Text = "以X排序";
            this.sortByXButton.UseVisualStyleBackColor = true;
            this.sortByXButton.Click += new System.EventHandler(this.sortByXButton_Click);
            // 
            // sortByYButton
            // 
            this.sortByYButton.Location = new System.Drawing.Point(162, 12);
            this.sortByYButton.Name = "sortByYButton";
            this.sortByYButton.Size = new System.Drawing.Size(144, 69);
            this.sortByYButton.TabIndex = 2;
            this.sortByYButton.Text = "以Y排序";
            this.sortByYButton.UseVisualStyleBackColor = true;
            this.sortByYButton.Click += new System.EventHandler(this.sortByYButton_Click);
            // 
            // sortByLengthButton
            // 
            this.sortByLengthButton.Location = new System.Drawing.Point(312, 12);
            this.sortByLengthButton.Name = "sortByLengthButton";
            this.sortByLengthButton.Size = new System.Drawing.Size(144, 69);
            this.sortByLengthButton.TabIndex = 3;
            this.sortByLengthButton.Text = "以Length排序";
            this.sortByLengthButton.UseVisualStyleBackColor = true;
            this.sortByLengthButton.Click += new System.EventHandler(this.sortByLengthButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 438);
            this.Controls.Add(this.sortByLengthButton);
            this.Controls.Add(this.sortByYButton);
            this.Controls.Add(this.sortByXButton);
            this.Controls.Add(this.resultRichTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox resultRichTextBox;
        private System.Windows.Forms.Button sortByXButton;
        private System.Windows.Forms.Button sortByYButton;
        private System.Windows.Forms.Button sortByLengthButton;
    }
}

