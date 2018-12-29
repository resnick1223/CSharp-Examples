namespace TableListForms
{
    partial class TableListForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maintainbutton = new System.Windows.Forms.Button();
            this.retiredbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TableListForms.Properties.Resources.toyota_reason_to_own_2014_qualit_tcm_11_42746;
            this.pictureBox1.Location = new System.Drawing.Point(-53, -92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(490, 416);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // maintainbutton
            // 
            this.maintainbutton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.maintainbutton.Location = new System.Drawing.Point(267, 46);
            this.maintainbutton.Name = "maintainbutton";
            this.maintainbutton.Size = new System.Drawing.Size(120, 46);
            this.maintainbutton.TabIndex = 2;
            this.maintainbutton.Text = "保養系統";
            this.maintainbutton.UseVisualStyleBackColor = true;
            this.maintainbutton.Click += new System.EventHandler(this.maintainbutton_Click);
            // 
            // retiredbutton
            // 
            this.retiredbutton.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.retiredbutton.Location = new System.Drawing.Point(267, 110);
            this.retiredbutton.Name = "retiredbutton";
            this.retiredbutton.Size = new System.Drawing.Size(120, 46);
            this.retiredbutton.TabIndex = 3;
            this.retiredbutton.Text = "休旅車";
            this.retiredbutton.UseVisualStyleBackColor = true;
            this.retiredbutton.Click += new System.EventHandler(this.retiredbutton_Click);
            // 
            // TableListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 261);
            this.Controls.Add(this.retiredbutton);
            this.Controls.Add(this.maintainbutton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TableListForm";
            this.Text = "Toyota Service";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button maintainbutton;
        private System.Windows.Forms.Button retiredbutton;
    }
}

