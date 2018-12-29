namespace TestWindowsFormsApp
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
            this.components = new System.ComponentModel.Container();
            this.pokemon1Label = new System.Windows.Forms.Label();
            this.pokemon2Label = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pokemon1Label
            // 
            this.pokemon1Label.Location = new System.Drawing.Point(33, 36);
            this.pokemon1Label.Name = "pokemon1Label";
            this.pokemon1Label.Size = new System.Drawing.Size(193, 133);
            this.pokemon1Label.TabIndex = 0;
            this.pokemon1Label.Text = "pokemon1";
            this.pokemon1Label.Click += new System.EventHandler(this.pokemon1Label_Click);
            // 
            // pokemon2Label
            // 
            this.pokemon2Label.Location = new System.Drawing.Point(265, 36);
            this.pokemon2Label.Name = "pokemon2Label";
            this.pokemon2Label.Size = new System.Drawing.Size(210, 137);
            this.pokemon2Label.TabIndex = 1;
            this.pokemon2Label.Text = "pokemon2";
            this.pokemon2Label.Click += new System.EventHandler(this.pokemon2Label_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 236);
            this.Controls.Add(this.pokemon2Label);
            this.Controls.Add(this.pokemon1Label);
            this.Font = new System.Drawing.Font("新細明體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pokemon1Label;
        private System.Windows.Forms.Label pokemon2Label;
        private System.Windows.Forms.Timer gameTimer;
    }
}

